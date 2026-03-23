
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsWebhooksResponseWebhookJobFlavor
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
    public static class GetSettingsWebhooksResponseWebhookJobFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsWebhooksResponseWebhookJobFlavor value)
        {
            return value switch
            {
                GetSettingsWebhooksResponseWebhookJobFlavor.A100Large => "a100-large",
                GetSettingsWebhooksResponseWebhookJobFlavor.A100x4 => "a100x4",
                GetSettingsWebhooksResponseWebhookJobFlavor.A100x8 => "a100x8",
                GetSettingsWebhooksResponseWebhookJobFlavor.A10gLarge => "a10g-large",
                GetSettingsWebhooksResponseWebhookJobFlavor.A10gLargex2 => "a10g-largex2",
                GetSettingsWebhooksResponseWebhookJobFlavor.A10gLargex4 => "a10g-largex4",
                GetSettingsWebhooksResponseWebhookJobFlavor.A10gSmall => "a10g-small",
                GetSettingsWebhooksResponseWebhookJobFlavor.CpuBasic => "cpu-basic",
                GetSettingsWebhooksResponseWebhookJobFlavor.CpuPerformance => "cpu-performance",
                GetSettingsWebhooksResponseWebhookJobFlavor.CpuUpgrade => "cpu-upgrade",
                GetSettingsWebhooksResponseWebhookJobFlavor.CpuXl => "cpu-xl",
                GetSettingsWebhooksResponseWebhookJobFlavor.H200 => "h200",
                GetSettingsWebhooksResponseWebhookJobFlavor.H200x2 => "h200x2",
                GetSettingsWebhooksResponseWebhookJobFlavor.H200x4 => "h200x4",
                GetSettingsWebhooksResponseWebhookJobFlavor.H200x8 => "h200x8",
                GetSettingsWebhooksResponseWebhookJobFlavor.Inf2x6 => "inf2x6",
                GetSettingsWebhooksResponseWebhookJobFlavor.L40sx1 => "l40sx1",
                GetSettingsWebhooksResponseWebhookJobFlavor.L40sx4 => "l40sx4",
                GetSettingsWebhooksResponseWebhookJobFlavor.L40sx8 => "l40sx8",
                GetSettingsWebhooksResponseWebhookJobFlavor.L4x1 => "l4x1",
                GetSettingsWebhooksResponseWebhookJobFlavor.L4x4 => "l4x4",
                GetSettingsWebhooksResponseWebhookJobFlavor.Sprx8 => "sprx8",
                GetSettingsWebhooksResponseWebhookJobFlavor.T4Medium => "t4-medium",
                GetSettingsWebhooksResponseWebhookJobFlavor.T4Small => "t4-small",
                GetSettingsWebhooksResponseWebhookJobFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsWebhooksResponseWebhookJobFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => GetSettingsWebhooksResponseWebhookJobFlavor.A100Large,
                "a100x4" => GetSettingsWebhooksResponseWebhookJobFlavor.A100x4,
                "a100x8" => GetSettingsWebhooksResponseWebhookJobFlavor.A100x8,
                "a10g-large" => GetSettingsWebhooksResponseWebhookJobFlavor.A10gLarge,
                "a10g-largex2" => GetSettingsWebhooksResponseWebhookJobFlavor.A10gLargex2,
                "a10g-largex4" => GetSettingsWebhooksResponseWebhookJobFlavor.A10gLargex4,
                "a10g-small" => GetSettingsWebhooksResponseWebhookJobFlavor.A10gSmall,
                "cpu-basic" => GetSettingsWebhooksResponseWebhookJobFlavor.CpuBasic,
                "cpu-performance" => GetSettingsWebhooksResponseWebhookJobFlavor.CpuPerformance,
                "cpu-upgrade" => GetSettingsWebhooksResponseWebhookJobFlavor.CpuUpgrade,
                "cpu-xl" => GetSettingsWebhooksResponseWebhookJobFlavor.CpuXl,
                "h200" => GetSettingsWebhooksResponseWebhookJobFlavor.H200,
                "h200x2" => GetSettingsWebhooksResponseWebhookJobFlavor.H200x2,
                "h200x4" => GetSettingsWebhooksResponseWebhookJobFlavor.H200x4,
                "h200x8" => GetSettingsWebhooksResponseWebhookJobFlavor.H200x8,
                "inf2x6" => GetSettingsWebhooksResponseWebhookJobFlavor.Inf2x6,
                "l40sx1" => GetSettingsWebhooksResponseWebhookJobFlavor.L40sx1,
                "l40sx4" => GetSettingsWebhooksResponseWebhookJobFlavor.L40sx4,
                "l40sx8" => GetSettingsWebhooksResponseWebhookJobFlavor.L40sx8,
                "l4x1" => GetSettingsWebhooksResponseWebhookJobFlavor.L4x1,
                "l4x4" => GetSettingsWebhooksResponseWebhookJobFlavor.L4x4,
                "sprx8" => GetSettingsWebhooksResponseWebhookJobFlavor.Sprx8,
                "t4-medium" => GetSettingsWebhooksResponseWebhookJobFlavor.T4Medium,
                "t4-small" => GetSettingsWebhooksResponseWebhookJobFlavor.T4Small,
                "zero-a10g" => GetSettingsWebhooksResponseWebhookJobFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}