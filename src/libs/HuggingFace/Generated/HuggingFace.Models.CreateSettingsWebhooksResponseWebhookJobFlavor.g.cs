
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksResponseWebhookJobFlavor
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
    public static class CreateSettingsWebhooksResponseWebhookJobFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksResponseWebhookJobFlavor value)
        {
            return value switch
            {
                CreateSettingsWebhooksResponseWebhookJobFlavor.A100Large => "a100-large",
                CreateSettingsWebhooksResponseWebhookJobFlavor.A100x4 => "a100x4",
                CreateSettingsWebhooksResponseWebhookJobFlavor.A100x8 => "a100x8",
                CreateSettingsWebhooksResponseWebhookJobFlavor.A10gLarge => "a10g-large",
                CreateSettingsWebhooksResponseWebhookJobFlavor.A10gLargex2 => "a10g-largex2",
                CreateSettingsWebhooksResponseWebhookJobFlavor.A10gLargex4 => "a10g-largex4",
                CreateSettingsWebhooksResponseWebhookJobFlavor.A10gSmall => "a10g-small",
                CreateSettingsWebhooksResponseWebhookJobFlavor.CpuBasic => "cpu-basic",
                CreateSettingsWebhooksResponseWebhookJobFlavor.CpuPerformance => "cpu-performance",
                CreateSettingsWebhooksResponseWebhookJobFlavor.CpuUpgrade => "cpu-upgrade",
                CreateSettingsWebhooksResponseWebhookJobFlavor.CpuXl => "cpu-xl",
                CreateSettingsWebhooksResponseWebhookJobFlavor.H200 => "h200",
                CreateSettingsWebhooksResponseWebhookJobFlavor.H200x2 => "h200x2",
                CreateSettingsWebhooksResponseWebhookJobFlavor.H200x4 => "h200x4",
                CreateSettingsWebhooksResponseWebhookJobFlavor.H200x8 => "h200x8",
                CreateSettingsWebhooksResponseWebhookJobFlavor.Inf2x6 => "inf2x6",
                CreateSettingsWebhooksResponseWebhookJobFlavor.L40sx1 => "l40sx1",
                CreateSettingsWebhooksResponseWebhookJobFlavor.L40sx4 => "l40sx4",
                CreateSettingsWebhooksResponseWebhookJobFlavor.L40sx8 => "l40sx8",
                CreateSettingsWebhooksResponseWebhookJobFlavor.L4x1 => "l4x1",
                CreateSettingsWebhooksResponseWebhookJobFlavor.L4x4 => "l4x4",
                CreateSettingsWebhooksResponseWebhookJobFlavor.Sprx8 => "sprx8",
                CreateSettingsWebhooksResponseWebhookJobFlavor.T4Medium => "t4-medium",
                CreateSettingsWebhooksResponseWebhookJobFlavor.T4Small => "t4-small",
                CreateSettingsWebhooksResponseWebhookJobFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksResponseWebhookJobFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateSettingsWebhooksResponseWebhookJobFlavor.A100Large,
                "a100x4" => CreateSettingsWebhooksResponseWebhookJobFlavor.A100x4,
                "a100x8" => CreateSettingsWebhooksResponseWebhookJobFlavor.A100x8,
                "a10g-large" => CreateSettingsWebhooksResponseWebhookJobFlavor.A10gLarge,
                "a10g-largex2" => CreateSettingsWebhooksResponseWebhookJobFlavor.A10gLargex2,
                "a10g-largex4" => CreateSettingsWebhooksResponseWebhookJobFlavor.A10gLargex4,
                "a10g-small" => CreateSettingsWebhooksResponseWebhookJobFlavor.A10gSmall,
                "cpu-basic" => CreateSettingsWebhooksResponseWebhookJobFlavor.CpuBasic,
                "cpu-performance" => CreateSettingsWebhooksResponseWebhookJobFlavor.CpuPerformance,
                "cpu-upgrade" => CreateSettingsWebhooksResponseWebhookJobFlavor.CpuUpgrade,
                "cpu-xl" => CreateSettingsWebhooksResponseWebhookJobFlavor.CpuXl,
                "h200" => CreateSettingsWebhooksResponseWebhookJobFlavor.H200,
                "h200x2" => CreateSettingsWebhooksResponseWebhookJobFlavor.H200x2,
                "h200x4" => CreateSettingsWebhooksResponseWebhookJobFlavor.H200x4,
                "h200x8" => CreateSettingsWebhooksResponseWebhookJobFlavor.H200x8,
                "inf2x6" => CreateSettingsWebhooksResponseWebhookJobFlavor.Inf2x6,
                "l40sx1" => CreateSettingsWebhooksResponseWebhookJobFlavor.L40sx1,
                "l40sx4" => CreateSettingsWebhooksResponseWebhookJobFlavor.L40sx4,
                "l40sx8" => CreateSettingsWebhooksResponseWebhookJobFlavor.L40sx8,
                "l4x1" => CreateSettingsWebhooksResponseWebhookJobFlavor.L4x1,
                "l4x4" => CreateSettingsWebhooksResponseWebhookJobFlavor.L4x4,
                "sprx8" => CreateSettingsWebhooksResponseWebhookJobFlavor.Sprx8,
                "t4-medium" => CreateSettingsWebhooksResponseWebhookJobFlavor.T4Medium,
                "t4-small" => CreateSettingsWebhooksResponseWebhookJobFlavor.T4Small,
                "zero-a10g" => CreateSettingsWebhooksResponseWebhookJobFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}