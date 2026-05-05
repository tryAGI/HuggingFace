
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutScheduledJobsLabelsResponseJobSpecFlavor
    {
        /// <summary>
        /// 
        /// </summary>
        A100Large,
        /// <summary>
        /// 
        /// </summary>
        A100x4,
        /// <summary>
        /// 
        /// </summary>
        A100x8,
        /// <summary>
        /// 
        /// </summary>
        A10gLarge,
        /// <summary>
        /// 
        /// </summary>
        A10gLargex2,
        /// <summary>
        /// 
        /// </summary>
        A10gLargex4,
        /// <summary>
        /// 
        /// </summary>
        A10gSmall,
        /// <summary>
        /// 
        /// </summary>
        CpuBasic,
        /// <summary>
        /// 
        /// </summary>
        CpuPerformance,
        /// <summary>
        /// 
        /// </summary>
        CpuUpgrade,
        /// <summary>
        /// 
        /// </summary>
        CpuXl,
        /// <summary>
        /// 
        /// </summary>
        H200,
        /// <summary>
        /// 
        /// </summary>
        H200x2,
        /// <summary>
        /// 
        /// </summary>
        H200x4,
        /// <summary>
        /// 
        /// </summary>
        H200x8,
        /// <summary>
        /// 
        /// </summary>
        Inf2x6,
        /// <summary>
        /// 
        /// </summary>
        L40sx1,
        /// <summary>
        /// 
        /// </summary>
        L40sx4,
        /// <summary>
        /// 
        /// </summary>
        L40sx8,
        /// <summary>
        /// 
        /// </summary>
        L4x1,
        /// <summary>
        /// 
        /// </summary>
        L4x4,
        /// <summary>
        /// 
        /// </summary>
        Sprx8,
        /// <summary>
        /// 
        /// </summary>
        T4Medium,
        /// <summary>
        /// 
        /// </summary>
        T4Small,
        /// <summary>
        /// 
        /// </summary>
        ZeroA10g,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutScheduledJobsLabelsResponseJobSpecFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutScheduledJobsLabelsResponseJobSpecFlavor value)
        {
            return value switch
            {
                PutScheduledJobsLabelsResponseJobSpecFlavor.A100Large => "a100-large",
                PutScheduledJobsLabelsResponseJobSpecFlavor.A100x4 => "a100x4",
                PutScheduledJobsLabelsResponseJobSpecFlavor.A100x8 => "a100x8",
                PutScheduledJobsLabelsResponseJobSpecFlavor.A10gLarge => "a10g-large",
                PutScheduledJobsLabelsResponseJobSpecFlavor.A10gLargex2 => "a10g-largex2",
                PutScheduledJobsLabelsResponseJobSpecFlavor.A10gLargex4 => "a10g-largex4",
                PutScheduledJobsLabelsResponseJobSpecFlavor.A10gSmall => "a10g-small",
                PutScheduledJobsLabelsResponseJobSpecFlavor.CpuBasic => "cpu-basic",
                PutScheduledJobsLabelsResponseJobSpecFlavor.CpuPerformance => "cpu-performance",
                PutScheduledJobsLabelsResponseJobSpecFlavor.CpuUpgrade => "cpu-upgrade",
                PutScheduledJobsLabelsResponseJobSpecFlavor.CpuXl => "cpu-xl",
                PutScheduledJobsLabelsResponseJobSpecFlavor.H200 => "h200",
                PutScheduledJobsLabelsResponseJobSpecFlavor.H200x2 => "h200x2",
                PutScheduledJobsLabelsResponseJobSpecFlavor.H200x4 => "h200x4",
                PutScheduledJobsLabelsResponseJobSpecFlavor.H200x8 => "h200x8",
                PutScheduledJobsLabelsResponseJobSpecFlavor.Inf2x6 => "inf2x6",
                PutScheduledJobsLabelsResponseJobSpecFlavor.L40sx1 => "l40sx1",
                PutScheduledJobsLabelsResponseJobSpecFlavor.L40sx4 => "l40sx4",
                PutScheduledJobsLabelsResponseJobSpecFlavor.L40sx8 => "l40sx8",
                PutScheduledJobsLabelsResponseJobSpecFlavor.L4x1 => "l4x1",
                PutScheduledJobsLabelsResponseJobSpecFlavor.L4x4 => "l4x4",
                PutScheduledJobsLabelsResponseJobSpecFlavor.Sprx8 => "sprx8",
                PutScheduledJobsLabelsResponseJobSpecFlavor.T4Medium => "t4-medium",
                PutScheduledJobsLabelsResponseJobSpecFlavor.T4Small => "t4-small",
                PutScheduledJobsLabelsResponseJobSpecFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutScheduledJobsLabelsResponseJobSpecFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => PutScheduledJobsLabelsResponseJobSpecFlavor.A100Large,
                "a100x4" => PutScheduledJobsLabelsResponseJobSpecFlavor.A100x4,
                "a100x8" => PutScheduledJobsLabelsResponseJobSpecFlavor.A100x8,
                "a10g-large" => PutScheduledJobsLabelsResponseJobSpecFlavor.A10gLarge,
                "a10g-largex2" => PutScheduledJobsLabelsResponseJobSpecFlavor.A10gLargex2,
                "a10g-largex4" => PutScheduledJobsLabelsResponseJobSpecFlavor.A10gLargex4,
                "a10g-small" => PutScheduledJobsLabelsResponseJobSpecFlavor.A10gSmall,
                "cpu-basic" => PutScheduledJobsLabelsResponseJobSpecFlavor.CpuBasic,
                "cpu-performance" => PutScheduledJobsLabelsResponseJobSpecFlavor.CpuPerformance,
                "cpu-upgrade" => PutScheduledJobsLabelsResponseJobSpecFlavor.CpuUpgrade,
                "cpu-xl" => PutScheduledJobsLabelsResponseJobSpecFlavor.CpuXl,
                "h200" => PutScheduledJobsLabelsResponseJobSpecFlavor.H200,
                "h200x2" => PutScheduledJobsLabelsResponseJobSpecFlavor.H200x2,
                "h200x4" => PutScheduledJobsLabelsResponseJobSpecFlavor.H200x4,
                "h200x8" => PutScheduledJobsLabelsResponseJobSpecFlavor.H200x8,
                "inf2x6" => PutScheduledJobsLabelsResponseJobSpecFlavor.Inf2x6,
                "l40sx1" => PutScheduledJobsLabelsResponseJobSpecFlavor.L40sx1,
                "l40sx4" => PutScheduledJobsLabelsResponseJobSpecFlavor.L40sx4,
                "l40sx8" => PutScheduledJobsLabelsResponseJobSpecFlavor.L40sx8,
                "l4x1" => PutScheduledJobsLabelsResponseJobSpecFlavor.L4x1,
                "l4x4" => PutScheduledJobsLabelsResponseJobSpecFlavor.L4x4,
                "sprx8" => PutScheduledJobsLabelsResponseJobSpecFlavor.Sprx8,
                "t4-medium" => PutScheduledJobsLabelsResponseJobSpecFlavor.T4Medium,
                "t4-small" => PutScheduledJobsLabelsResponseJobSpecFlavor.T4Small,
                "zero-a10g" => PutScheduledJobsLabelsResponseJobSpecFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}