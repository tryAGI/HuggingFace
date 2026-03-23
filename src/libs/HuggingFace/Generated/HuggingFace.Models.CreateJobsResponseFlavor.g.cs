
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsResponseFlavor
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
    public static class CreateJobsResponseFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsResponseFlavor value)
        {
            return value switch
            {
                CreateJobsResponseFlavor.A100Large => "a100-large",
                CreateJobsResponseFlavor.A100x4 => "a100x4",
                CreateJobsResponseFlavor.A100x8 => "a100x8",
                CreateJobsResponseFlavor.A10gLarge => "a10g-large",
                CreateJobsResponseFlavor.A10gLargex2 => "a10g-largex2",
                CreateJobsResponseFlavor.A10gLargex4 => "a10g-largex4",
                CreateJobsResponseFlavor.A10gSmall => "a10g-small",
                CreateJobsResponseFlavor.CpuBasic => "cpu-basic",
                CreateJobsResponseFlavor.CpuPerformance => "cpu-performance",
                CreateJobsResponseFlavor.CpuUpgrade => "cpu-upgrade",
                CreateJobsResponseFlavor.CpuXl => "cpu-xl",
                CreateJobsResponseFlavor.H200 => "h200",
                CreateJobsResponseFlavor.H200x2 => "h200x2",
                CreateJobsResponseFlavor.H200x4 => "h200x4",
                CreateJobsResponseFlavor.H200x8 => "h200x8",
                CreateJobsResponseFlavor.Inf2x6 => "inf2x6",
                CreateJobsResponseFlavor.L40sx1 => "l40sx1",
                CreateJobsResponseFlavor.L40sx4 => "l40sx4",
                CreateJobsResponseFlavor.L40sx8 => "l40sx8",
                CreateJobsResponseFlavor.L4x1 => "l4x1",
                CreateJobsResponseFlavor.L4x4 => "l4x4",
                CreateJobsResponseFlavor.Sprx8 => "sprx8",
                CreateJobsResponseFlavor.T4Medium => "t4-medium",
                CreateJobsResponseFlavor.T4Small => "t4-small",
                CreateJobsResponseFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsResponseFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateJobsResponseFlavor.A100Large,
                "a100x4" => CreateJobsResponseFlavor.A100x4,
                "a100x8" => CreateJobsResponseFlavor.A100x8,
                "a10g-large" => CreateJobsResponseFlavor.A10gLarge,
                "a10g-largex2" => CreateJobsResponseFlavor.A10gLargex2,
                "a10g-largex4" => CreateJobsResponseFlavor.A10gLargex4,
                "a10g-small" => CreateJobsResponseFlavor.A10gSmall,
                "cpu-basic" => CreateJobsResponseFlavor.CpuBasic,
                "cpu-performance" => CreateJobsResponseFlavor.CpuPerformance,
                "cpu-upgrade" => CreateJobsResponseFlavor.CpuUpgrade,
                "cpu-xl" => CreateJobsResponseFlavor.CpuXl,
                "h200" => CreateJobsResponseFlavor.H200,
                "h200x2" => CreateJobsResponseFlavor.H200x2,
                "h200x4" => CreateJobsResponseFlavor.H200x4,
                "h200x8" => CreateJobsResponseFlavor.H200x8,
                "inf2x6" => CreateJobsResponseFlavor.Inf2x6,
                "l40sx1" => CreateJobsResponseFlavor.L40sx1,
                "l40sx4" => CreateJobsResponseFlavor.L40sx4,
                "l40sx8" => CreateJobsResponseFlavor.L40sx8,
                "l4x1" => CreateJobsResponseFlavor.L4x1,
                "l4x4" => CreateJobsResponseFlavor.L4x4,
                "sprx8" => CreateJobsResponseFlavor.Sprx8,
                "t4-medium" => CreateJobsResponseFlavor.T4Medium,
                "t4-small" => CreateJobsResponseFlavor.T4Small,
                "zero-a10g" => CreateJobsResponseFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}