
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksResponseWebhookJobFlavor3
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
    public static class CreateSettingsWebhooksResponseWebhookJobFlavor3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksResponseWebhookJobFlavor3 value)
        {
            return value switch
            {
                CreateSettingsWebhooksResponseWebhookJobFlavor3.A100Large => "a100-large",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.A100x4 => "a100x4",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.A100x8 => "a100x8",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.A10gLarge => "a10g-large",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.A10gLargex2 => "a10g-largex2",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.A10gLargex4 => "a10g-largex4",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.A10gSmall => "a10g-small",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.CpuBasic => "cpu-basic",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.CpuPerformance => "cpu-performance",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.CpuUpgrade => "cpu-upgrade",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.CpuXl => "cpu-xl",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.H200 => "h200",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.H200x2 => "h200x2",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.H200x4 => "h200x4",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.H200x8 => "h200x8",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.Inf2x6 => "inf2x6",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.L40sx1 => "l40sx1",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.L40sx4 => "l40sx4",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.L40sx8 => "l40sx8",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.L4x1 => "l4x1",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.L4x4 => "l4x4",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.Sprx8 => "sprx8",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.T4Medium => "t4-medium",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.T4Small => "t4-small",
                CreateSettingsWebhooksResponseWebhookJobFlavor3.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksResponseWebhookJobFlavor3? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateSettingsWebhooksResponseWebhookJobFlavor3.A100Large,
                "a100x4" => CreateSettingsWebhooksResponseWebhookJobFlavor3.A100x4,
                "a100x8" => CreateSettingsWebhooksResponseWebhookJobFlavor3.A100x8,
                "a10g-large" => CreateSettingsWebhooksResponseWebhookJobFlavor3.A10gLarge,
                "a10g-largex2" => CreateSettingsWebhooksResponseWebhookJobFlavor3.A10gLargex2,
                "a10g-largex4" => CreateSettingsWebhooksResponseWebhookJobFlavor3.A10gLargex4,
                "a10g-small" => CreateSettingsWebhooksResponseWebhookJobFlavor3.A10gSmall,
                "cpu-basic" => CreateSettingsWebhooksResponseWebhookJobFlavor3.CpuBasic,
                "cpu-performance" => CreateSettingsWebhooksResponseWebhookJobFlavor3.CpuPerformance,
                "cpu-upgrade" => CreateSettingsWebhooksResponseWebhookJobFlavor3.CpuUpgrade,
                "cpu-xl" => CreateSettingsWebhooksResponseWebhookJobFlavor3.CpuXl,
                "h200" => CreateSettingsWebhooksResponseWebhookJobFlavor3.H200,
                "h200x2" => CreateSettingsWebhooksResponseWebhookJobFlavor3.H200x2,
                "h200x4" => CreateSettingsWebhooksResponseWebhookJobFlavor3.H200x4,
                "h200x8" => CreateSettingsWebhooksResponseWebhookJobFlavor3.H200x8,
                "inf2x6" => CreateSettingsWebhooksResponseWebhookJobFlavor3.Inf2x6,
                "l40sx1" => CreateSettingsWebhooksResponseWebhookJobFlavor3.L40sx1,
                "l40sx4" => CreateSettingsWebhooksResponseWebhookJobFlavor3.L40sx4,
                "l40sx8" => CreateSettingsWebhooksResponseWebhookJobFlavor3.L40sx8,
                "l4x1" => CreateSettingsWebhooksResponseWebhookJobFlavor3.L4x1,
                "l4x4" => CreateSettingsWebhooksResponseWebhookJobFlavor3.L4x4,
                "sprx8" => CreateSettingsWebhooksResponseWebhookJobFlavor3.Sprx8,
                "t4-medium" => CreateSettingsWebhooksResponseWebhookJobFlavor3.T4Medium,
                "t4-small" => CreateSettingsWebhooksResponseWebhookJobFlavor3.T4Small,
                "zero-a10g" => CreateSettingsWebhooksResponseWebhookJobFlavor3.ZeroA10g,
                _ => null,
            };
        }
    }
}