
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsRunResponseFlavor
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
    public static class CreateScheduledJobsRunResponseFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsRunResponseFlavor value)
        {
            return value switch
            {
                CreateScheduledJobsRunResponseFlavor.A100Large => "a100-large",
                CreateScheduledJobsRunResponseFlavor.A100x4 => "a100x4",
                CreateScheduledJobsRunResponseFlavor.A100x8 => "a100x8",
                CreateScheduledJobsRunResponseFlavor.A10gLarge => "a10g-large",
                CreateScheduledJobsRunResponseFlavor.A10gLargex2 => "a10g-largex2",
                CreateScheduledJobsRunResponseFlavor.A10gLargex4 => "a10g-largex4",
                CreateScheduledJobsRunResponseFlavor.A10gSmall => "a10g-small",
                CreateScheduledJobsRunResponseFlavor.CpuBasic => "cpu-basic",
                CreateScheduledJobsRunResponseFlavor.CpuPerformance => "cpu-performance",
                CreateScheduledJobsRunResponseFlavor.CpuUpgrade => "cpu-upgrade",
                CreateScheduledJobsRunResponseFlavor.CpuXl => "cpu-xl",
                CreateScheduledJobsRunResponseFlavor.H200 => "h200",
                CreateScheduledJobsRunResponseFlavor.H200x2 => "h200x2",
                CreateScheduledJobsRunResponseFlavor.H200x4 => "h200x4",
                CreateScheduledJobsRunResponseFlavor.H200x8 => "h200x8",
                CreateScheduledJobsRunResponseFlavor.Inf2x6 => "inf2x6",
                CreateScheduledJobsRunResponseFlavor.L40sx1 => "l40sx1",
                CreateScheduledJobsRunResponseFlavor.L40sx4 => "l40sx4",
                CreateScheduledJobsRunResponseFlavor.L40sx8 => "l40sx8",
                CreateScheduledJobsRunResponseFlavor.L4x1 => "l4x1",
                CreateScheduledJobsRunResponseFlavor.L4x4 => "l4x4",
                CreateScheduledJobsRunResponseFlavor.Sprx8 => "sprx8",
                CreateScheduledJobsRunResponseFlavor.T4Medium => "t4-medium",
                CreateScheduledJobsRunResponseFlavor.T4Small => "t4-small",
                CreateScheduledJobsRunResponseFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsRunResponseFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateScheduledJobsRunResponseFlavor.A100Large,
                "a100x4" => CreateScheduledJobsRunResponseFlavor.A100x4,
                "a100x8" => CreateScheduledJobsRunResponseFlavor.A100x8,
                "a10g-large" => CreateScheduledJobsRunResponseFlavor.A10gLarge,
                "a10g-largex2" => CreateScheduledJobsRunResponseFlavor.A10gLargex2,
                "a10g-largex4" => CreateScheduledJobsRunResponseFlavor.A10gLargex4,
                "a10g-small" => CreateScheduledJobsRunResponseFlavor.A10gSmall,
                "cpu-basic" => CreateScheduledJobsRunResponseFlavor.CpuBasic,
                "cpu-performance" => CreateScheduledJobsRunResponseFlavor.CpuPerformance,
                "cpu-upgrade" => CreateScheduledJobsRunResponseFlavor.CpuUpgrade,
                "cpu-xl" => CreateScheduledJobsRunResponseFlavor.CpuXl,
                "h200" => CreateScheduledJobsRunResponseFlavor.H200,
                "h200x2" => CreateScheduledJobsRunResponseFlavor.H200x2,
                "h200x4" => CreateScheduledJobsRunResponseFlavor.H200x4,
                "h200x8" => CreateScheduledJobsRunResponseFlavor.H200x8,
                "inf2x6" => CreateScheduledJobsRunResponseFlavor.Inf2x6,
                "l40sx1" => CreateScheduledJobsRunResponseFlavor.L40sx1,
                "l40sx4" => CreateScheduledJobsRunResponseFlavor.L40sx4,
                "l40sx8" => CreateScheduledJobsRunResponseFlavor.L40sx8,
                "l4x1" => CreateScheduledJobsRunResponseFlavor.L4x1,
                "l4x4" => CreateScheduledJobsRunResponseFlavor.L4x4,
                "sprx8" => CreateScheduledJobsRunResponseFlavor.Sprx8,
                "t4-medium" => CreateScheduledJobsRunResponseFlavor.T4Medium,
                "t4-small" => CreateScheduledJobsRunResponseFlavor.T4Small,
                "zero-a10g" => CreateScheduledJobsRunResponseFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}