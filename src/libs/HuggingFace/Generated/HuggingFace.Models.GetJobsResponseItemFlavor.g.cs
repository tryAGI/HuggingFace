
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsResponseItemFlavor
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
    public static class GetJobsResponseItemFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsResponseItemFlavor value)
        {
            return value switch
            {
                GetJobsResponseItemFlavor.A100Large => "a100-large",
                GetJobsResponseItemFlavor.A100x4 => "a100x4",
                GetJobsResponseItemFlavor.A100x8 => "a100x8",
                GetJobsResponseItemFlavor.A10gLarge => "a10g-large",
                GetJobsResponseItemFlavor.A10gLargex2 => "a10g-largex2",
                GetJobsResponseItemFlavor.A10gLargex4 => "a10g-largex4",
                GetJobsResponseItemFlavor.A10gSmall => "a10g-small",
                GetJobsResponseItemFlavor.CpuBasic => "cpu-basic",
                GetJobsResponseItemFlavor.CpuPerformance => "cpu-performance",
                GetJobsResponseItemFlavor.CpuUpgrade => "cpu-upgrade",
                GetJobsResponseItemFlavor.CpuXl => "cpu-xl",
                GetJobsResponseItemFlavor.H200 => "h200",
                GetJobsResponseItemFlavor.H200x2 => "h200x2",
                GetJobsResponseItemFlavor.H200x4 => "h200x4",
                GetJobsResponseItemFlavor.H200x8 => "h200x8",
                GetJobsResponseItemFlavor.Inf2x6 => "inf2x6",
                GetJobsResponseItemFlavor.L40sx1 => "l40sx1",
                GetJobsResponseItemFlavor.L40sx4 => "l40sx4",
                GetJobsResponseItemFlavor.L40sx8 => "l40sx8",
                GetJobsResponseItemFlavor.L4x1 => "l4x1",
                GetJobsResponseItemFlavor.L4x4 => "l4x4",
                GetJobsResponseItemFlavor.Sprx8 => "sprx8",
                GetJobsResponseItemFlavor.T4Medium => "t4-medium",
                GetJobsResponseItemFlavor.T4Small => "t4-small",
                GetJobsResponseItemFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsResponseItemFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => GetJobsResponseItemFlavor.A100Large,
                "a100x4" => GetJobsResponseItemFlavor.A100x4,
                "a100x8" => GetJobsResponseItemFlavor.A100x8,
                "a10g-large" => GetJobsResponseItemFlavor.A10gLarge,
                "a10g-largex2" => GetJobsResponseItemFlavor.A10gLargex2,
                "a10g-largex4" => GetJobsResponseItemFlavor.A10gLargex4,
                "a10g-small" => GetJobsResponseItemFlavor.A10gSmall,
                "cpu-basic" => GetJobsResponseItemFlavor.CpuBasic,
                "cpu-performance" => GetJobsResponseItemFlavor.CpuPerformance,
                "cpu-upgrade" => GetJobsResponseItemFlavor.CpuUpgrade,
                "cpu-xl" => GetJobsResponseItemFlavor.CpuXl,
                "h200" => GetJobsResponseItemFlavor.H200,
                "h200x2" => GetJobsResponseItemFlavor.H200x2,
                "h200x4" => GetJobsResponseItemFlavor.H200x4,
                "h200x8" => GetJobsResponseItemFlavor.H200x8,
                "inf2x6" => GetJobsResponseItemFlavor.Inf2x6,
                "l40sx1" => GetJobsResponseItemFlavor.L40sx1,
                "l40sx4" => GetJobsResponseItemFlavor.L40sx4,
                "l40sx8" => GetJobsResponseItemFlavor.L40sx8,
                "l4x1" => GetJobsResponseItemFlavor.L4x1,
                "l4x4" => GetJobsResponseItemFlavor.L4x4,
                "sprx8" => GetJobsResponseItemFlavor.Sprx8,
                "t4-medium" => GetJobsResponseItemFlavor.T4Medium,
                "t4-small" => GetJobsResponseItemFlavor.T4Small,
                "zero-a10g" => GetJobsResponseItemFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}