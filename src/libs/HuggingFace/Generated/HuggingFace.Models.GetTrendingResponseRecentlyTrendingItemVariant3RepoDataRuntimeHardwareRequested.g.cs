
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested
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
        RtxPro6000,
        /// <summary>
        ///
        /// </summary>
        RtxPro6000x2,
        /// <summary>
        ///
        /// </summary>
        RtxPro6000x4,
        /// <summary>
        ///
        /// </summary>
        RtxPro6000x8,
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
    public static class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequestedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A100Large => "a100-large",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A100x4 => "a100x4",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A100x8 => "a100x8",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A10gLarge => "a10g-large",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A10gLargex2 => "a10g-largex2",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A10gLargex4 => "a10g-largex4",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A10gSmall => "a10g-small",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.CpuBasic => "cpu-basic",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.CpuPerformance => "cpu-performance",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.CpuUpgrade => "cpu-upgrade",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.CpuXl => "cpu-xl",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.H200 => "h200",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.H200x2 => "h200x2",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.H200x4 => "h200x4",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.H200x8 => "h200x8",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.Inf2x6 => "inf2x6",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.L40sx1 => "l40sx1",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.L40sx4 => "l40sx4",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.L40sx8 => "l40sx8",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.L4x1 => "l4x1",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.L4x4 => "l4x4",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.RtxPro6000 => "rtx-pro-6000",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.RtxPro6000x2 => "rtx-pro-6000x2",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.RtxPro6000x4 => "rtx-pro-6000x4",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.RtxPro6000x8 => "rtx-pro-6000x8",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.Sprx8 => "sprx8",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.T4Medium => "t4-medium",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.T4Small => "t4-small",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A100Large,
                "a100x4" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A100x4,
                "a100x8" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A100x8,
                "a10g-large" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A10gLarge,
                "a10g-largex2" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A10gLargex2,
                "a10g-largex4" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A10gLargex4,
                "a10g-small" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.A10gSmall,
                "cpu-basic" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.CpuBasic,
                "cpu-performance" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.CpuPerformance,
                "cpu-upgrade" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.CpuUpgrade,
                "cpu-xl" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.CpuXl,
                "h200" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.H200,
                "h200x2" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.H200x2,
                "h200x4" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.H200x4,
                "h200x8" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.H200x8,
                "inf2x6" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.Inf2x6,
                "l40sx1" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.L40sx1,
                "l40sx4" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.L40sx4,
                "l40sx8" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.L40sx8,
                "l4x1" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.L4x1,
                "l4x4" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.L4x4,
                "rtx-pro-6000" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.RtxPro6000,
                "rtx-pro-6000x2" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.RtxPro6000x2,
                "rtx-pro-6000x4" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.RtxPro6000x4,
                "rtx-pro-6000x8" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.RtxPro6000x8,
                "sprx8" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.Sprx8,
                "t4-medium" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.T4Medium,
                "t4-small" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.T4Small,
                "zero-a10g" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested.ZeroA10g,
                _ => null,
            };
        }
    }
}