﻿using System.Collections.Generic;

namespace Core.BinaryFskAnalysis
{
    public interface IFrequencyDetector
    {
        int DetectFrequency(IList<float> samples);
    }
}
