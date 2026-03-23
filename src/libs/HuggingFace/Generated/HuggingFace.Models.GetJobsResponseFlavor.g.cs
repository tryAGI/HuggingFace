
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsResponseFlavor
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
    public static class GetJobsResponseFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsResponseFlavor value)
        {
            return value switch
            {
                GetJobsResponseFlavor.A100Large => "a100-large",
                GetJobsResponseFlavor.A100x4 => "a100x4",
                GetJobsResponseFlavor.A100x8 => "a100x8",
                GetJobsResponseFlavor.A10gLarge => "a10g-large",
                GetJobsResponseFlavor.A10gLargex2 => "a10g-largex2",
                GetJobsResponseFlavor.A10gLargex4 => "a10g-largex4",
                GetJobsResponseFlavor.A10gSmall => "a10g-small",
                GetJobsResponseFlavor.CpuBasic => "cpu-basic",
                GetJobsResponseFlavor.CpuPerformance => "cpu-performance",
                GetJobsResponseFlavor.CpuUpgrade => "cpu-upgrade",
                GetJobsResponseFlavor.CpuXl => "cpu-xl",
                GetJobsResponseFlavor.H200 => "h200",
                GetJobsResponseFlavor.H200x2 => "h200x2",
                GetJobsResponseFlavor.H200x4 => "h200x4",
                GetJobsResponseFlavor.H200x8 => "h200x8",
                GetJobsResponseFlavor.Inf2x6 => "inf2x6",
                GetJobsResponseFlavor.L40sx1 => "l40sx1",
                GetJobsResponseFlavor.L40sx4 => "l40sx4",
                GetJobsResponseFlavor.L40sx8 => "l40sx8",
                GetJobsResponseFlavor.L4x1 => "l4x1",
                GetJobsResponseFlavor.L4x4 => "l4x4",
                GetJobsResponseFlavor.Sprx8 => "sprx8",
                GetJobsResponseFlavor.T4Medium => "t4-medium",
                GetJobsResponseFlavor.T4Small => "t4-small",
                GetJobsResponseFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsResponseFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => GetJobsResponseFlavor.A100Large,
                "a100x4" => GetJobsResponseFlavor.A100x4,
                "a100x8" => GetJobsResponseFlavor.A100x8,
                "a10g-large" => GetJobsResponseFlavor.A10gLarge,
                "a10g-largex2" => GetJobsResponseFlavor.A10gLargex2,
                "a10g-largex4" => GetJobsResponseFlavor.A10gLargex4,
                "a10g-small" => GetJobsResponseFlavor.A10gSmall,
                "cpu-basic" => GetJobsResponseFlavor.CpuBasic,
                "cpu-performance" => GetJobsResponseFlavor.CpuPerformance,
                "cpu-upgrade" => GetJobsResponseFlavor.CpuUpgrade,
                "cpu-xl" => GetJobsResponseFlavor.CpuXl,
                "h200" => GetJobsResponseFlavor.H200,
                "h200x2" => GetJobsResponseFlavor.H200x2,
                "h200x4" => GetJobsResponseFlavor.H200x4,
                "h200x8" => GetJobsResponseFlavor.H200x8,
                "inf2x6" => GetJobsResponseFlavor.Inf2x6,
                "l40sx1" => GetJobsResponseFlavor.L40sx1,
                "l40sx4" => GetJobsResponseFlavor.L40sx4,
                "l40sx8" => GetJobsResponseFlavor.L40sx8,
                "l4x1" => GetJobsResponseFlavor.L4x1,
                "l4x4" => GetJobsResponseFlavor.L4x4,
                "sprx8" => GetJobsResponseFlavor.Sprx8,
                "t4-medium" => GetJobsResponseFlavor.T4Medium,
                "t4-small" => GetJobsResponseFlavor.T4Small,
                "zero-a10g" => GetJobsResponseFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}