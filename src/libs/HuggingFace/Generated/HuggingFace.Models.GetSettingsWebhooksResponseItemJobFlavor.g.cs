
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsWebhooksResponseItemJobFlavor
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
    public static class GetSettingsWebhooksResponseItemJobFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsWebhooksResponseItemJobFlavor value)
        {
            return value switch
            {
                GetSettingsWebhooksResponseItemJobFlavor.A100Large => "a100-large",
                GetSettingsWebhooksResponseItemJobFlavor.A100x4 => "a100x4",
                GetSettingsWebhooksResponseItemJobFlavor.A100x8 => "a100x8",
                GetSettingsWebhooksResponseItemJobFlavor.A10gLarge => "a10g-large",
                GetSettingsWebhooksResponseItemJobFlavor.A10gLargex2 => "a10g-largex2",
                GetSettingsWebhooksResponseItemJobFlavor.A10gLargex4 => "a10g-largex4",
                GetSettingsWebhooksResponseItemJobFlavor.A10gSmall => "a10g-small",
                GetSettingsWebhooksResponseItemJobFlavor.CpuBasic => "cpu-basic",
                GetSettingsWebhooksResponseItemJobFlavor.CpuPerformance => "cpu-performance",
                GetSettingsWebhooksResponseItemJobFlavor.CpuUpgrade => "cpu-upgrade",
                GetSettingsWebhooksResponseItemJobFlavor.CpuXl => "cpu-xl",
                GetSettingsWebhooksResponseItemJobFlavor.H200 => "h200",
                GetSettingsWebhooksResponseItemJobFlavor.H200x2 => "h200x2",
                GetSettingsWebhooksResponseItemJobFlavor.H200x4 => "h200x4",
                GetSettingsWebhooksResponseItemJobFlavor.H200x8 => "h200x8",
                GetSettingsWebhooksResponseItemJobFlavor.Inf2x6 => "inf2x6",
                GetSettingsWebhooksResponseItemJobFlavor.L40sx1 => "l40sx1",
                GetSettingsWebhooksResponseItemJobFlavor.L40sx4 => "l40sx4",
                GetSettingsWebhooksResponseItemJobFlavor.L40sx8 => "l40sx8",
                GetSettingsWebhooksResponseItemJobFlavor.L4x1 => "l4x1",
                GetSettingsWebhooksResponseItemJobFlavor.L4x4 => "l4x4",
                GetSettingsWebhooksResponseItemJobFlavor.Sprx8 => "sprx8",
                GetSettingsWebhooksResponseItemJobFlavor.T4Medium => "t4-medium",
                GetSettingsWebhooksResponseItemJobFlavor.T4Small => "t4-small",
                GetSettingsWebhooksResponseItemJobFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsWebhooksResponseItemJobFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => GetSettingsWebhooksResponseItemJobFlavor.A100Large,
                "a100x4" => GetSettingsWebhooksResponseItemJobFlavor.A100x4,
                "a100x8" => GetSettingsWebhooksResponseItemJobFlavor.A100x8,
                "a10g-large" => GetSettingsWebhooksResponseItemJobFlavor.A10gLarge,
                "a10g-largex2" => GetSettingsWebhooksResponseItemJobFlavor.A10gLargex2,
                "a10g-largex4" => GetSettingsWebhooksResponseItemJobFlavor.A10gLargex4,
                "a10g-small" => GetSettingsWebhooksResponseItemJobFlavor.A10gSmall,
                "cpu-basic" => GetSettingsWebhooksResponseItemJobFlavor.CpuBasic,
                "cpu-performance" => GetSettingsWebhooksResponseItemJobFlavor.CpuPerformance,
                "cpu-upgrade" => GetSettingsWebhooksResponseItemJobFlavor.CpuUpgrade,
                "cpu-xl" => GetSettingsWebhooksResponseItemJobFlavor.CpuXl,
                "h200" => GetSettingsWebhooksResponseItemJobFlavor.H200,
                "h200x2" => GetSettingsWebhooksResponseItemJobFlavor.H200x2,
                "h200x4" => GetSettingsWebhooksResponseItemJobFlavor.H200x4,
                "h200x8" => GetSettingsWebhooksResponseItemJobFlavor.H200x8,
                "inf2x6" => GetSettingsWebhooksResponseItemJobFlavor.Inf2x6,
                "l40sx1" => GetSettingsWebhooksResponseItemJobFlavor.L40sx1,
                "l40sx4" => GetSettingsWebhooksResponseItemJobFlavor.L40sx4,
                "l40sx8" => GetSettingsWebhooksResponseItemJobFlavor.L40sx8,
                "l4x1" => GetSettingsWebhooksResponseItemJobFlavor.L4x1,
                "l4x4" => GetSettingsWebhooksResponseItemJobFlavor.L4x4,
                "sprx8" => GetSettingsWebhooksResponseItemJobFlavor.Sprx8,
                "t4-medium" => GetSettingsWebhooksResponseItemJobFlavor.T4Medium,
                "t4-small" => GetSettingsWebhooksResponseItemJobFlavor.T4Small,
                "zero-a10g" => GetSettingsWebhooksResponseItemJobFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}