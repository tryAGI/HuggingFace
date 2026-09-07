
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateJobsRequestVariant2Flavor
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
    public static class CreateJobsRequestVariant2FlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsRequestVariant2Flavor value)
        {
            return value switch
            {
                CreateJobsRequestVariant2Flavor.A100Large => "a100-large",
                CreateJobsRequestVariant2Flavor.A100x4 => "a100x4",
                CreateJobsRequestVariant2Flavor.A100x8 => "a100x8",
                CreateJobsRequestVariant2Flavor.A10gLarge => "a10g-large",
                CreateJobsRequestVariant2Flavor.A10gLargex2 => "a10g-largex2",
                CreateJobsRequestVariant2Flavor.A10gLargex4 => "a10g-largex4",
                CreateJobsRequestVariant2Flavor.A10gSmall => "a10g-small",
                CreateJobsRequestVariant2Flavor.CpuBasic => "cpu-basic",
                CreateJobsRequestVariant2Flavor.CpuPerformance => "cpu-performance",
                CreateJobsRequestVariant2Flavor.CpuUpgrade => "cpu-upgrade",
                CreateJobsRequestVariant2Flavor.CpuXl => "cpu-xl",
                CreateJobsRequestVariant2Flavor.H200 => "h200",
                CreateJobsRequestVariant2Flavor.H200x2 => "h200x2",
                CreateJobsRequestVariant2Flavor.H200x4 => "h200x4",
                CreateJobsRequestVariant2Flavor.H200x8 => "h200x8",
                CreateJobsRequestVariant2Flavor.Inf2x6 => "inf2x6",
                CreateJobsRequestVariant2Flavor.L40sx1 => "l40sx1",
                CreateJobsRequestVariant2Flavor.L40sx4 => "l40sx4",
                CreateJobsRequestVariant2Flavor.L40sx8 => "l40sx8",
                CreateJobsRequestVariant2Flavor.L4x1 => "l4x1",
                CreateJobsRequestVariant2Flavor.L4x4 => "l4x4",
                CreateJobsRequestVariant2Flavor.RtxPro6000 => "rtx-pro-6000",
                CreateJobsRequestVariant2Flavor.RtxPro6000x2 => "rtx-pro-6000x2",
                CreateJobsRequestVariant2Flavor.RtxPro6000x4 => "rtx-pro-6000x4",
                CreateJobsRequestVariant2Flavor.RtxPro6000x8 => "rtx-pro-6000x8",
                CreateJobsRequestVariant2Flavor.Sprx8 => "sprx8",
                CreateJobsRequestVariant2Flavor.T4Medium => "t4-medium",
                CreateJobsRequestVariant2Flavor.T4Small => "t4-small",
                CreateJobsRequestVariant2Flavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsRequestVariant2Flavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateJobsRequestVariant2Flavor.A100Large,
                "a100x4" => CreateJobsRequestVariant2Flavor.A100x4,
                "a100x8" => CreateJobsRequestVariant2Flavor.A100x8,
                "a10g-large" => CreateJobsRequestVariant2Flavor.A10gLarge,
                "a10g-largex2" => CreateJobsRequestVariant2Flavor.A10gLargex2,
                "a10g-largex4" => CreateJobsRequestVariant2Flavor.A10gLargex4,
                "a10g-small" => CreateJobsRequestVariant2Flavor.A10gSmall,
                "cpu-basic" => CreateJobsRequestVariant2Flavor.CpuBasic,
                "cpu-performance" => CreateJobsRequestVariant2Flavor.CpuPerformance,
                "cpu-upgrade" => CreateJobsRequestVariant2Flavor.CpuUpgrade,
                "cpu-xl" => CreateJobsRequestVariant2Flavor.CpuXl,
                "h200" => CreateJobsRequestVariant2Flavor.H200,
                "h200x2" => CreateJobsRequestVariant2Flavor.H200x2,
                "h200x4" => CreateJobsRequestVariant2Flavor.H200x4,
                "h200x8" => CreateJobsRequestVariant2Flavor.H200x8,
                "inf2x6" => CreateJobsRequestVariant2Flavor.Inf2x6,
                "l40sx1" => CreateJobsRequestVariant2Flavor.L40sx1,
                "l40sx4" => CreateJobsRequestVariant2Flavor.L40sx4,
                "l40sx8" => CreateJobsRequestVariant2Flavor.L40sx8,
                "l4x1" => CreateJobsRequestVariant2Flavor.L4x1,
                "l4x4" => CreateJobsRequestVariant2Flavor.L4x4,
                "rtx-pro-6000" => CreateJobsRequestVariant2Flavor.RtxPro6000,
                "rtx-pro-6000x2" => CreateJobsRequestVariant2Flavor.RtxPro6000x2,
                "rtx-pro-6000x4" => CreateJobsRequestVariant2Flavor.RtxPro6000x4,
                "rtx-pro-6000x8" => CreateJobsRequestVariant2Flavor.RtxPro6000x8,
                "sprx8" => CreateJobsRequestVariant2Flavor.Sprx8,
                "t4-medium" => CreateJobsRequestVariant2Flavor.T4Medium,
                "t4-small" => CreateJobsRequestVariant2Flavor.T4Small,
                "zero-a10g" => CreateJobsRequestVariant2Flavor.ZeroA10g,
                _ => null,
            };
        }
    }
}