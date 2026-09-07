
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSettingsWebhooksResponseWebhookJobVariant1Flavor
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
    public static class GetSettingsWebhooksResponseWebhookJobVariant1FlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsWebhooksResponseWebhookJobVariant1Flavor value)
        {
            return value switch
            {
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A100Large => "a100-large",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A100x4 => "a100x4",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A100x8 => "a100x8",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A10gLarge => "a10g-large",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A10gLargex2 => "a10g-largex2",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A10gLargex4 => "a10g-largex4",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A10gSmall => "a10g-small",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.CpuBasic => "cpu-basic",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.CpuPerformance => "cpu-performance",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.CpuUpgrade => "cpu-upgrade",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.CpuXl => "cpu-xl",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.H200 => "h200",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.H200x2 => "h200x2",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.H200x4 => "h200x4",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.H200x8 => "h200x8",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.Inf2x6 => "inf2x6",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.L40sx1 => "l40sx1",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.L40sx4 => "l40sx4",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.L40sx8 => "l40sx8",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.L4x1 => "l4x1",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.L4x4 => "l4x4",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.RtxPro6000 => "rtx-pro-6000",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.RtxPro6000x2 => "rtx-pro-6000x2",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.RtxPro6000x4 => "rtx-pro-6000x4",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.RtxPro6000x8 => "rtx-pro-6000x8",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.Sprx8 => "sprx8",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.T4Medium => "t4-medium",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.T4Small => "t4-small",
                GetSettingsWebhooksResponseWebhookJobVariant1Flavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsWebhooksResponseWebhookJobVariant1Flavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A100Large,
                "a100x4" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A100x4,
                "a100x8" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A100x8,
                "a10g-large" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A10gLarge,
                "a10g-largex2" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A10gLargex2,
                "a10g-largex4" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A10gLargex4,
                "a10g-small" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.A10gSmall,
                "cpu-basic" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.CpuBasic,
                "cpu-performance" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.CpuPerformance,
                "cpu-upgrade" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.CpuUpgrade,
                "cpu-xl" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.CpuXl,
                "h200" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.H200,
                "h200x2" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.H200x2,
                "h200x4" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.H200x4,
                "h200x8" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.H200x8,
                "inf2x6" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.Inf2x6,
                "l40sx1" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.L40sx1,
                "l40sx4" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.L40sx4,
                "l40sx8" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.L40sx8,
                "l4x1" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.L4x1,
                "l4x4" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.L4x4,
                "rtx-pro-6000" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.RtxPro6000,
                "rtx-pro-6000x2" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.RtxPro6000x2,
                "rtx-pro-6000x4" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.RtxPro6000x4,
                "rtx-pro-6000x8" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.RtxPro6000x8,
                "sprx8" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.Sprx8,
                "t4-medium" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.T4Medium,
                "t4-small" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.T4Small,
                "zero-a10g" => GetSettingsWebhooksResponseWebhookJobVariant1Flavor.ZeroA10g,
                _ => null,
            };
        }
    }
}