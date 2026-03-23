
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsRequestFlavor
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
    public static class CreateJobsRequestFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsRequestFlavor value)
        {
            return value switch
            {
                CreateJobsRequestFlavor.A100Large => "a100-large",
                CreateJobsRequestFlavor.A100x4 => "a100x4",
                CreateJobsRequestFlavor.A100x8 => "a100x8",
                CreateJobsRequestFlavor.A10gLarge => "a10g-large",
                CreateJobsRequestFlavor.A10gLargex2 => "a10g-largex2",
                CreateJobsRequestFlavor.A10gLargex4 => "a10g-largex4",
                CreateJobsRequestFlavor.A10gSmall => "a10g-small",
                CreateJobsRequestFlavor.CpuBasic => "cpu-basic",
                CreateJobsRequestFlavor.CpuPerformance => "cpu-performance",
                CreateJobsRequestFlavor.CpuUpgrade => "cpu-upgrade",
                CreateJobsRequestFlavor.CpuXl => "cpu-xl",
                CreateJobsRequestFlavor.H200 => "h200",
                CreateJobsRequestFlavor.H200x2 => "h200x2",
                CreateJobsRequestFlavor.H200x4 => "h200x4",
                CreateJobsRequestFlavor.H200x8 => "h200x8",
                CreateJobsRequestFlavor.Inf2x6 => "inf2x6",
                CreateJobsRequestFlavor.L40sx1 => "l40sx1",
                CreateJobsRequestFlavor.L40sx4 => "l40sx4",
                CreateJobsRequestFlavor.L40sx8 => "l40sx8",
                CreateJobsRequestFlavor.L4x1 => "l4x1",
                CreateJobsRequestFlavor.L4x4 => "l4x4",
                CreateJobsRequestFlavor.Sprx8 => "sprx8",
                CreateJobsRequestFlavor.T4Medium => "t4-medium",
                CreateJobsRequestFlavor.T4Small => "t4-small",
                CreateJobsRequestFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsRequestFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateJobsRequestFlavor.A100Large,
                "a100x4" => CreateJobsRequestFlavor.A100x4,
                "a100x8" => CreateJobsRequestFlavor.A100x8,
                "a10g-large" => CreateJobsRequestFlavor.A10gLarge,
                "a10g-largex2" => CreateJobsRequestFlavor.A10gLargex2,
                "a10g-largex4" => CreateJobsRequestFlavor.A10gLargex4,
                "a10g-small" => CreateJobsRequestFlavor.A10gSmall,
                "cpu-basic" => CreateJobsRequestFlavor.CpuBasic,
                "cpu-performance" => CreateJobsRequestFlavor.CpuPerformance,
                "cpu-upgrade" => CreateJobsRequestFlavor.CpuUpgrade,
                "cpu-xl" => CreateJobsRequestFlavor.CpuXl,
                "h200" => CreateJobsRequestFlavor.H200,
                "h200x2" => CreateJobsRequestFlavor.H200x2,
                "h200x4" => CreateJobsRequestFlavor.H200x4,
                "h200x8" => CreateJobsRequestFlavor.H200x8,
                "inf2x6" => CreateJobsRequestFlavor.Inf2x6,
                "l40sx1" => CreateJobsRequestFlavor.L40sx1,
                "l40sx4" => CreateJobsRequestFlavor.L40sx4,
                "l40sx8" => CreateJobsRequestFlavor.L40sx8,
                "l4x1" => CreateJobsRequestFlavor.L4x1,
                "l4x4" => CreateJobsRequestFlavor.L4x4,
                "sprx8" => CreateJobsRequestFlavor.Sprx8,
                "t4-medium" => CreateJobsRequestFlavor.T4Medium,
                "t4-small" => CreateJobsRequestFlavor.T4Small,
                "zero-a10g" => CreateJobsRequestFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}