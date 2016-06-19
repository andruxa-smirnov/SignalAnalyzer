﻿using System.Collections.Generic;
using System;
using System.Diagnostics;
using Core.AudioAnalysis;

namespace Core.BinaryFskAnalysis
{
    public class BinaryFskAnalyzer : IBinaryFskAnalyzer
    {
        private IAudioAnalyzer _audioAnalyzer;
        private IFrequencyDetector _frequencyDetector;
        private BinaryFskAnalyzerSettings _settings;

        public BinaryFskAnalyzer(IAudioAnalyzer audioAnalyzer, IFrequencyDetector frequencyDetector,
            BinaryFskAnalyzerSettings binaryFskAnalzyerSettings)
        {
            if (audioAnalyzer == null)
            {
                throw new ArgumentNullException(nameof(audioAnalyzer));
            }

            if (frequencyDetector == null)
            {
                throw new ArgumentNullException(nameof(frequencyDetector));
            }

            if (binaryFskAnalzyerSettings == null)
            {
                throw new ArgumentNullException(nameof(binaryFskAnalzyerSettings));
            }

            _audioAnalyzer = audioAnalyzer;
            _frequencyDetector = frequencyDetector;
            _settings = ProcessSettings(binaryFskAnalzyerSettings);
        }

        public ICollection<bool> AnalyzeSignal()
        {
            var bits = new List<bool>();

            if (_settings.WindowPositionEndMilliseconds == null)
            {
                _settings.WindowPositionEndMilliseconds = _audioAnalyzer.FileLengthInMilliseconds;

                Debug.WriteLine($"Set window end position to total length of audio ({_settings.WindowPositionEndMilliseconds} ms)");
            }

            for (var currentWindowStart = _settings.WindowPositionStartMilliseconds; currentWindowStart <= _settings.WindowPositionEndMilliseconds; currentWindowStart += _settings.WindowPositionIncrementMilliseconds.Value)
            {
                for (var currentWindowLength = _settings.WindowLengthStartMilliseconds; currentWindowLength <= _settings.WindowLengthEndMilliseconds; currentWindowLength += _settings.WindowLengthIncrementMilliseconds)
                {
                    var samplingResult = _audioAnalyzer.GetSamples(currentWindowStart, currentWindowStart + currentWindowLength);
                    var frequency = _frequencyDetector.DetectFrequency(samplingResult.Samples);
                    var frequencyDifference = FrequencyDifference(frequency, _settings.SpaceFrequency, _settings.MarkFrequency);
                    var markOrSpace = MarkOrSpace(frequency, _settings.SpaceFrequency, _settings.MarkFrequency);

                    if (frequencyDifference > _settings.FrequencyDeviationTolerance)
                    {
                        Debug.WriteLine($"WARN: Frequency outside of tolerance (frequency {frequency} Hz, difference {frequencyDifference} Hz, tolerance {_settings.FrequencyDeviationTolerance} Hz)");
                        continue;
                    }

                    Debug.WriteLine($"[{currentWindowStart:N3} ms to {currentWindowStart + currentWindowLength:N3} ms ({(currentWindowStart + currentWindowLength) - currentWindowStart:N3} ms)] {frequency:N0} Hz average (+/- {frequencyDifference:N0} Hz) [Want {_settings.MarkFrequency:N0} Hz / {_settings.SpaceFrequency:N0} Hz] -> bit {bits.Count}: {markOrSpace}");

                    bits.Add(markOrSpace == 0 ? false : true);
                }
            }

            return bits;
        }

        private static int FrequencyDifference(int frequency, int spaceFrequency, int markFrequency)
        {
            int distanceFromSpaceFrequency = Math.Abs(frequency - spaceFrequency);
            int distanceFromMarkFrequency = Math.Abs(frequency - markFrequency);

            return distanceFromSpaceFrequency <= distanceFromMarkFrequency ? distanceFromSpaceFrequency : distanceFromMarkFrequency;
        }

        private static int MarkOrSpace(int frequency, int spaceFrequency, int markFrequency)
        {
            int distanceFromSpaceFrequency = Math.Abs(frequency - spaceFrequency);
            int distanceFromMarkFrequency = Math.Abs(frequency - markFrequency);

            return distanceFromSpaceFrequency <= distanceFromMarkFrequency ? 0 : 1;
        }

        private BinaryFskAnalyzerSettings ProcessSettings(BinaryFskAnalyzerSettings sourceSettings)
        {
            var updatedSettings = new BinaryFskAnalyzerSettings(sourceSettings);

            var baudRateIncrement = 1.0 / updatedSettings.BaudRate * 1000.0;

            if (updatedSettings.WindowPositionIncrementMilliseconds == null)
            {
                updatedSettings.WindowPositionIncrementMilliseconds = baudRateIncrement;
            }

            if (updatedSettings.WindowLengthStartMilliseconds == null)
            {
                updatedSettings.WindowLengthStartMilliseconds = baudRateIncrement;
            }

            if (updatedSettings.WindowLengthIncrementMilliseconds == null)
            {
                updatedSettings.WindowLengthIncrementMilliseconds = 1.0;
            }

            if (updatedSettings.WindowLengthEndMilliseconds == null)
            {
                updatedSettings.WindowLengthEndMilliseconds = baudRateIncrement;
            }

            return updatedSettings;
        }

        private class WindowSample
        {
            public int Frequency { get; set; }
            public int Distance { get; set; }
            public int WindowStartPosition { get; set; }
            public int WindowLength { get; set; }
        }
    }
}
