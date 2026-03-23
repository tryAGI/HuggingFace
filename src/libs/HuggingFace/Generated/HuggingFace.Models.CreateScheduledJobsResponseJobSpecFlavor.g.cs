
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsResponseJobSpecFlavor
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
    public static class CreateScheduledJobsResponseJobSpecFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsResponseJobSpecFlavor value)
        {
            return value switch
            {
                CreateScheduledJobsResponseJobSpecFlavor.A100Large => "a100-large",
                CreateScheduledJobsResponseJobSpecFlavor.A100x4 => "a100x4",
                CreateScheduledJobsResponseJobSpecFlavor.A100x8 => "a100x8",
                CreateScheduledJobsResponseJobSpecFlavor.A10gLarge => "a10g-large",
                CreateScheduledJobsResponseJobSpecFlavor.A10gLargex2 => "a10g-largex2",
                CreateScheduledJobsResponseJobSpecFlavor.A10gLargex4 => "a10g-largex4",
                CreateScheduledJobsResponseJobSpecFlavor.A10gSmall => "a10g-small",
                CreateScheduledJobsResponseJobSpecFlavor.CpuBasic => "cpu-basic",
                CreateScheduledJobsResponseJobSpecFlavor.CpuPerformance => "cpu-performance",
                CreateScheduledJobsResponseJobSpecFlavor.CpuUpgrade => "cpu-upgrade",
                CreateScheduledJobsResponseJobSpecFlavor.CpuXl => "cpu-xl",
                CreateScheduledJobsResponseJobSpecFlavor.H200 => "h200",
                CreateScheduledJobsResponseJobSpecFlavor.H200x2 => "h200x2",
                CreateScheduledJobsResponseJobSpecFlavor.H200x4 => "h200x4",
                CreateScheduledJobsResponseJobSpecFlavor.H200x8 => "h200x8",
                CreateScheduledJobsResponseJobSpecFlavor.Inf2x6 => "inf2x6",
                CreateScheduledJobsResponseJobSpecFlavor.L40sx1 => "l40sx1",
                CreateScheduledJobsResponseJobSpecFlavor.L40sx4 => "l40sx4",
                CreateScheduledJobsResponseJobSpecFlavor.L40sx8 => "l40sx8",
                CreateScheduledJobsResponseJobSpecFlavor.L4x1 => "l4x1",
                CreateScheduledJobsResponseJobSpecFlavor.L4x4 => "l4x4",
                CreateScheduledJobsResponseJobSpecFlavor.Sprx8 => "sprx8",
                CreateScheduledJobsResponseJobSpecFlavor.T4Medium => "t4-medium",
                CreateScheduledJobsResponseJobSpecFlavor.T4Small => "t4-small",
                CreateScheduledJobsResponseJobSpecFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsResponseJobSpecFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateScheduledJobsResponseJobSpecFlavor.A100Large,
                "a100x4" => CreateScheduledJobsResponseJobSpecFlavor.A100x4,
                "a100x8" => CreateScheduledJobsResponseJobSpecFlavor.A100x8,
                "a10g-large" => CreateScheduledJobsResponseJobSpecFlavor.A10gLarge,
                "a10g-largex2" => CreateScheduledJobsResponseJobSpecFlavor.A10gLargex2,
                "a10g-largex4" => CreateScheduledJobsResponseJobSpecFlavor.A10gLargex4,
                "a10g-small" => CreateScheduledJobsResponseJobSpecFlavor.A10gSmall,
                "cpu-basic" => CreateScheduledJobsResponseJobSpecFlavor.CpuBasic,
                "cpu-performance" => CreateScheduledJobsResponseJobSpecFlavor.CpuPerformance,
                "cpu-upgrade" => CreateScheduledJobsResponseJobSpecFlavor.CpuUpgrade,
                "cpu-xl" => CreateScheduledJobsResponseJobSpecFlavor.CpuXl,
                "h200" => CreateScheduledJobsResponseJobSpecFlavor.H200,
                "h200x2" => CreateScheduledJobsResponseJobSpecFlavor.H200x2,
                "h200x4" => CreateScheduledJobsResponseJobSpecFlavor.H200x4,
                "h200x8" => CreateScheduledJobsResponseJobSpecFlavor.H200x8,
                "inf2x6" => CreateScheduledJobsResponseJobSpecFlavor.Inf2x6,
                "l40sx1" => CreateScheduledJobsResponseJobSpecFlavor.L40sx1,
                "l40sx4" => CreateScheduledJobsResponseJobSpecFlavor.L40sx4,
                "l40sx8" => CreateScheduledJobsResponseJobSpecFlavor.L40sx8,
                "l4x1" => CreateScheduledJobsResponseJobSpecFlavor.L4x1,
                "l4x4" => CreateScheduledJobsResponseJobSpecFlavor.L4x4,
                "sprx8" => CreateScheduledJobsResponseJobSpecFlavor.Sprx8,
                "t4-medium" => CreateScheduledJobsResponseJobSpecFlavor.T4Medium,
                "t4-small" => CreateScheduledJobsResponseJobSpecFlavor.T4Small,
                "zero-a10g" => CreateScheduledJobsResponseJobSpecFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}