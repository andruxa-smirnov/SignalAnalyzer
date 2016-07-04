﻿using System.Collections.Generic;

namespace Core.SignalAnalysis
{
    public interface IFftSignalAnalyzer
    {
        FftSignalAnalysisResult AnalyzeSignal(double? startMicroseconds = null,
            double? endMicroseconds = null, int minFftSize = 8192, int maxFftSize = 16384);

        ICollection<int> GetFrequencyCandidates(string filename,
            int windowPositionStart, int windowPositionEnd, int windowLengthStart, int windowLengthEnd,
            int numberOfClusters = 10, int cutoffFrequency = 4000);
    }
}
