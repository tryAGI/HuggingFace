
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2
    {
        /// <summary>
        /// 
        /// </summary>
        CpuBasic,
        /// <summary>
        /// 
        /// </summary>
        CpuUpgrade,
        /// <summary>
        /// 
        /// </summary>
        CpuPerformance,
        /// <summary>
        /// 
        /// </summary>
        CpuXl,
        /// <summary>
        /// 
        /// </summary>
        Sprx8,
        /// <summary>
        /// 
        /// </summary>
        ZeroA10g,
        /// <summary>
        /// 
        /// </summary>
        T4Small,
        /// <summary>
        /// 
        /// </summary>
        T4Medium,
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
        A10gSmall,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2 value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.CpuBasic => "cpu-basic",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.CpuUpgrade => "cpu-upgrade",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.CpuPerformance => "cpu-performance",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.CpuXl => "cpu-xl",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.Sprx8 => "sprx8",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.ZeroA10g => "zero-a10g",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.T4Small => "t4-small",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.T4Medium => "t4-medium",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.L4x1 => "l4x1",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.L4x4 => "l4x4",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.L40sx1 => "l40sx1",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.L40sx4 => "l40sx4",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.L40sx8 => "l40sx8",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A10gSmall => "a10g-small",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A10gLarge => "a10g-large",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A10gLargex2 => "a10g-largex2",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A10gLargex4 => "a10g-largex4",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A100Large => "a100-large",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A100x4 => "a100x4",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A100x8 => "a100x8",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.H200 => "h200",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.H200x2 => "h200x2",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.H200x4 => "h200x4",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.H200x8 => "h200x8",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.CpuBasic,
                "cpu-upgrade" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.CpuUpgrade,
                "cpu-performance" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.CpuPerformance,
                "cpu-xl" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.CpuXl,
                "sprx8" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.Sprx8,
                "zero-a10g" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.ZeroA10g,
                "t4-small" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.T4Small,
                "t4-medium" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.T4Medium,
                "l4x1" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.L4x1,
                "l4x4" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.L4x4,
                "l40sx1" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.L40sx1,
                "l40sx4" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.L40sx4,
                "l40sx8" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.L40sx8,
                "a10g-small" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A10gSmall,
                "a10g-large" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A10gLarge,
                "a10g-largex2" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A10gLargex2,
                "a10g-largex4" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A10gLargex4,
                "a100-large" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A100Large,
                "a100x4" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A100x4,
                "a100x8" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.A100x8,
                "h200" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.H200,
                "h200x2" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.H200x2,
                "h200x4" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.H200x4,
                "h200x8" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.H200x8,
                "inf2x6" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested2.Inf2x6,
                _ => null,
            };
        }
    }
}