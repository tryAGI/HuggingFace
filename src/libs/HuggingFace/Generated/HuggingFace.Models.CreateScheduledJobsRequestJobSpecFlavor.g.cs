
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsRequestJobSpecFlavor
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
    public static class CreateScheduledJobsRequestJobSpecFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsRequestJobSpecFlavor value)
        {
            return value switch
            {
                CreateScheduledJobsRequestJobSpecFlavor.A100Large => "a100-large",
                CreateScheduledJobsRequestJobSpecFlavor.A100x4 => "a100x4",
                CreateScheduledJobsRequestJobSpecFlavor.A100x8 => "a100x8",
                CreateScheduledJobsRequestJobSpecFlavor.A10gLarge => "a10g-large",
                CreateScheduledJobsRequestJobSpecFlavor.A10gLargex2 => "a10g-largex2",
                CreateScheduledJobsRequestJobSpecFlavor.A10gLargex4 => "a10g-largex4",
                CreateScheduledJobsRequestJobSpecFlavor.A10gSmall => "a10g-small",
                CreateScheduledJobsRequestJobSpecFlavor.CpuBasic => "cpu-basic",
                CreateScheduledJobsRequestJobSpecFlavor.CpuPerformance => "cpu-performance",
                CreateScheduledJobsRequestJobSpecFlavor.CpuUpgrade => "cpu-upgrade",
                CreateScheduledJobsRequestJobSpecFlavor.CpuXl => "cpu-xl",
                CreateScheduledJobsRequestJobSpecFlavor.H200 => "h200",
                CreateScheduledJobsRequestJobSpecFlavor.H200x2 => "h200x2",
                CreateScheduledJobsRequestJobSpecFlavor.H200x4 => "h200x4",
                CreateScheduledJobsRequestJobSpecFlavor.H200x8 => "h200x8",
                CreateScheduledJobsRequestJobSpecFlavor.Inf2x6 => "inf2x6",
                CreateScheduledJobsRequestJobSpecFlavor.L40sx1 => "l40sx1",
                CreateScheduledJobsRequestJobSpecFlavor.L40sx4 => "l40sx4",
                CreateScheduledJobsRequestJobSpecFlavor.L40sx8 => "l40sx8",
                CreateScheduledJobsRequestJobSpecFlavor.L4x1 => "l4x1",
                CreateScheduledJobsRequestJobSpecFlavor.L4x4 => "l4x4",
                CreateScheduledJobsRequestJobSpecFlavor.Sprx8 => "sprx8",
                CreateScheduledJobsRequestJobSpecFlavor.T4Medium => "t4-medium",
                CreateScheduledJobsRequestJobSpecFlavor.T4Small => "t4-small",
                CreateScheduledJobsRequestJobSpecFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsRequestJobSpecFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateScheduledJobsRequestJobSpecFlavor.A100Large,
                "a100x4" => CreateScheduledJobsRequestJobSpecFlavor.A100x4,
                "a100x8" => CreateScheduledJobsRequestJobSpecFlavor.A100x8,
                "a10g-large" => CreateScheduledJobsRequestJobSpecFlavor.A10gLarge,
                "a10g-largex2" => CreateScheduledJobsRequestJobSpecFlavor.A10gLargex2,
                "a10g-largex4" => CreateScheduledJobsRequestJobSpecFlavor.A10gLargex4,
                "a10g-small" => CreateScheduledJobsRequestJobSpecFlavor.A10gSmall,
                "cpu-basic" => CreateScheduledJobsRequestJobSpecFlavor.CpuBasic,
                "cpu-performance" => CreateScheduledJobsRequestJobSpecFlavor.CpuPerformance,
                "cpu-upgrade" => CreateScheduledJobsRequestJobSpecFlavor.CpuUpgrade,
                "cpu-xl" => CreateScheduledJobsRequestJobSpecFlavor.CpuXl,
                "h200" => CreateScheduledJobsRequestJobSpecFlavor.H200,
                "h200x2" => CreateScheduledJobsRequestJobSpecFlavor.H200x2,
                "h200x4" => CreateScheduledJobsRequestJobSpecFlavor.H200x4,
                "h200x8" => CreateScheduledJobsRequestJobSpecFlavor.H200x8,
                "inf2x6" => CreateScheduledJobsRequestJobSpecFlavor.Inf2x6,
                "l40sx1" => CreateScheduledJobsRequestJobSpecFlavor.L40sx1,
                "l40sx4" => CreateScheduledJobsRequestJobSpecFlavor.L40sx4,
                "l40sx8" => CreateScheduledJobsRequestJobSpecFlavor.L40sx8,
                "l4x1" => CreateScheduledJobsRequestJobSpecFlavor.L4x1,
                "l4x4" => CreateScheduledJobsRequestJobSpecFlavor.L4x4,
                "sprx8" => CreateScheduledJobsRequestJobSpecFlavor.Sprx8,
                "t4-medium" => CreateScheduledJobsRequestJobSpecFlavor.T4Medium,
                "t4-small" => CreateScheduledJobsRequestJobSpecFlavor.T4Small,
                "zero-a10g" => CreateScheduledJobsRequestJobSpecFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}