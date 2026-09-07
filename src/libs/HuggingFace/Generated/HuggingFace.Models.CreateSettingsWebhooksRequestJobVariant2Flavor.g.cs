
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSettingsWebhooksRequestJobVariant2Flavor
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
    public static class CreateSettingsWebhooksRequestJobVariant2FlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestJobVariant2Flavor value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestJobVariant2Flavor.A100Large => "a100-large",
                CreateSettingsWebhooksRequestJobVariant2Flavor.A100x4 => "a100x4",
                CreateSettingsWebhooksRequestJobVariant2Flavor.A100x8 => "a100x8",
                CreateSettingsWebhooksRequestJobVariant2Flavor.A10gLarge => "a10g-large",
                CreateSettingsWebhooksRequestJobVariant2Flavor.A10gLargex2 => "a10g-largex2",
                CreateSettingsWebhooksRequestJobVariant2Flavor.A10gLargex4 => "a10g-largex4",
                CreateSettingsWebhooksRequestJobVariant2Flavor.A10gSmall => "a10g-small",
                CreateSettingsWebhooksRequestJobVariant2Flavor.CpuBasic => "cpu-basic",
                CreateSettingsWebhooksRequestJobVariant2Flavor.CpuPerformance => "cpu-performance",
                CreateSettingsWebhooksRequestJobVariant2Flavor.CpuUpgrade => "cpu-upgrade",
                CreateSettingsWebhooksRequestJobVariant2Flavor.CpuXl => "cpu-xl",
                CreateSettingsWebhooksRequestJobVariant2Flavor.H200 => "h200",
                CreateSettingsWebhooksRequestJobVariant2Flavor.H200x2 => "h200x2",
                CreateSettingsWebhooksRequestJobVariant2Flavor.H200x4 => "h200x4",
                CreateSettingsWebhooksRequestJobVariant2Flavor.H200x8 => "h200x8",
                CreateSettingsWebhooksRequestJobVariant2Flavor.Inf2x6 => "inf2x6",
                CreateSettingsWebhooksRequestJobVariant2Flavor.L40sx1 => "l40sx1",
                CreateSettingsWebhooksRequestJobVariant2Flavor.L40sx4 => "l40sx4",
                CreateSettingsWebhooksRequestJobVariant2Flavor.L40sx8 => "l40sx8",
                CreateSettingsWebhooksRequestJobVariant2Flavor.L4x1 => "l4x1",
                CreateSettingsWebhooksRequestJobVariant2Flavor.L4x4 => "l4x4",
                CreateSettingsWebhooksRequestJobVariant2Flavor.RtxPro6000 => "rtx-pro-6000",
                CreateSettingsWebhooksRequestJobVariant2Flavor.RtxPro6000x2 => "rtx-pro-6000x2",
                CreateSettingsWebhooksRequestJobVariant2Flavor.RtxPro6000x4 => "rtx-pro-6000x4",
                CreateSettingsWebhooksRequestJobVariant2Flavor.RtxPro6000x8 => "rtx-pro-6000x8",
                CreateSettingsWebhooksRequestJobVariant2Flavor.Sprx8 => "sprx8",
                CreateSettingsWebhooksRequestJobVariant2Flavor.T4Medium => "t4-medium",
                CreateSettingsWebhooksRequestJobVariant2Flavor.T4Small => "t4-small",
                CreateSettingsWebhooksRequestJobVariant2Flavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestJobVariant2Flavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateSettingsWebhooksRequestJobVariant2Flavor.A100Large,
                "a100x4" => CreateSettingsWebhooksRequestJobVariant2Flavor.A100x4,
                "a100x8" => CreateSettingsWebhooksRequestJobVariant2Flavor.A100x8,
                "a10g-large" => CreateSettingsWebhooksRequestJobVariant2Flavor.A10gLarge,
                "a10g-largex2" => CreateSettingsWebhooksRequestJobVariant2Flavor.A10gLargex2,
                "a10g-largex4" => CreateSettingsWebhooksRequestJobVariant2Flavor.A10gLargex4,
                "a10g-small" => CreateSettingsWebhooksRequestJobVariant2Flavor.A10gSmall,
                "cpu-basic" => CreateSettingsWebhooksRequestJobVariant2Flavor.CpuBasic,
                "cpu-performance" => CreateSettingsWebhooksRequestJobVariant2Flavor.CpuPerformance,
                "cpu-upgrade" => CreateSettingsWebhooksRequestJobVariant2Flavor.CpuUpgrade,
                "cpu-xl" => CreateSettingsWebhooksRequestJobVariant2Flavor.CpuXl,
                "h200" => CreateSettingsWebhooksRequestJobVariant2Flavor.H200,
                "h200x2" => CreateSettingsWebhooksRequestJobVariant2Flavor.H200x2,
                "h200x4" => CreateSettingsWebhooksRequestJobVariant2Flavor.H200x4,
                "h200x8" => CreateSettingsWebhooksRequestJobVariant2Flavor.H200x8,
                "inf2x6" => CreateSettingsWebhooksRequestJobVariant2Flavor.Inf2x6,
                "l40sx1" => CreateSettingsWebhooksRequestJobVariant2Flavor.L40sx1,
                "l40sx4" => CreateSettingsWebhooksRequestJobVariant2Flavor.L40sx4,
                "l40sx8" => CreateSettingsWebhooksRequestJobVariant2Flavor.L40sx8,
                "l4x1" => CreateSettingsWebhooksRequestJobVariant2Flavor.L4x1,
                "l4x4" => CreateSettingsWebhooksRequestJobVariant2Flavor.L4x4,
                "rtx-pro-6000" => CreateSettingsWebhooksRequestJobVariant2Flavor.RtxPro6000,
                "rtx-pro-6000x2" => CreateSettingsWebhooksRequestJobVariant2Flavor.RtxPro6000x2,
                "rtx-pro-6000x4" => CreateSettingsWebhooksRequestJobVariant2Flavor.RtxPro6000x4,
                "rtx-pro-6000x8" => CreateSettingsWebhooksRequestJobVariant2Flavor.RtxPro6000x8,
                "sprx8" => CreateSettingsWebhooksRequestJobVariant2Flavor.Sprx8,
                "t4-medium" => CreateSettingsWebhooksRequestJobVariant2Flavor.T4Medium,
                "t4-small" => CreateSettingsWebhooksRequestJobVariant2Flavor.T4Small,
                "zero-a10g" => CreateSettingsWebhooksRequestJobVariant2Flavor.ZeroA10g,
                _ => null,
            };
        }
    }
}