
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksRequestJobFlavor
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
    public static class CreateSettingsWebhooksRequestJobFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestJobFlavor value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestJobFlavor.A100Large => "a100-large",
                CreateSettingsWebhooksRequestJobFlavor.A100x4 => "a100x4",
                CreateSettingsWebhooksRequestJobFlavor.A100x8 => "a100x8",
                CreateSettingsWebhooksRequestJobFlavor.A10gLarge => "a10g-large",
                CreateSettingsWebhooksRequestJobFlavor.A10gLargex2 => "a10g-largex2",
                CreateSettingsWebhooksRequestJobFlavor.A10gLargex4 => "a10g-largex4",
                CreateSettingsWebhooksRequestJobFlavor.A10gSmall => "a10g-small",
                CreateSettingsWebhooksRequestJobFlavor.CpuBasic => "cpu-basic",
                CreateSettingsWebhooksRequestJobFlavor.CpuPerformance => "cpu-performance",
                CreateSettingsWebhooksRequestJobFlavor.CpuUpgrade => "cpu-upgrade",
                CreateSettingsWebhooksRequestJobFlavor.CpuXl => "cpu-xl",
                CreateSettingsWebhooksRequestJobFlavor.H200 => "h200",
                CreateSettingsWebhooksRequestJobFlavor.H200x2 => "h200x2",
                CreateSettingsWebhooksRequestJobFlavor.H200x4 => "h200x4",
                CreateSettingsWebhooksRequestJobFlavor.H200x8 => "h200x8",
                CreateSettingsWebhooksRequestJobFlavor.Inf2x6 => "inf2x6",
                CreateSettingsWebhooksRequestJobFlavor.L40sx1 => "l40sx1",
                CreateSettingsWebhooksRequestJobFlavor.L40sx4 => "l40sx4",
                CreateSettingsWebhooksRequestJobFlavor.L40sx8 => "l40sx8",
                CreateSettingsWebhooksRequestJobFlavor.L4x1 => "l4x1",
                CreateSettingsWebhooksRequestJobFlavor.L4x4 => "l4x4",
                CreateSettingsWebhooksRequestJobFlavor.Sprx8 => "sprx8",
                CreateSettingsWebhooksRequestJobFlavor.T4Medium => "t4-medium",
                CreateSettingsWebhooksRequestJobFlavor.T4Small => "t4-small",
                CreateSettingsWebhooksRequestJobFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestJobFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateSettingsWebhooksRequestJobFlavor.A100Large,
                "a100x4" => CreateSettingsWebhooksRequestJobFlavor.A100x4,
                "a100x8" => CreateSettingsWebhooksRequestJobFlavor.A100x8,
                "a10g-large" => CreateSettingsWebhooksRequestJobFlavor.A10gLarge,
                "a10g-largex2" => CreateSettingsWebhooksRequestJobFlavor.A10gLargex2,
                "a10g-largex4" => CreateSettingsWebhooksRequestJobFlavor.A10gLargex4,
                "a10g-small" => CreateSettingsWebhooksRequestJobFlavor.A10gSmall,
                "cpu-basic" => CreateSettingsWebhooksRequestJobFlavor.CpuBasic,
                "cpu-performance" => CreateSettingsWebhooksRequestJobFlavor.CpuPerformance,
                "cpu-upgrade" => CreateSettingsWebhooksRequestJobFlavor.CpuUpgrade,
                "cpu-xl" => CreateSettingsWebhooksRequestJobFlavor.CpuXl,
                "h200" => CreateSettingsWebhooksRequestJobFlavor.H200,
                "h200x2" => CreateSettingsWebhooksRequestJobFlavor.H200x2,
                "h200x4" => CreateSettingsWebhooksRequestJobFlavor.H200x4,
                "h200x8" => CreateSettingsWebhooksRequestJobFlavor.H200x8,
                "inf2x6" => CreateSettingsWebhooksRequestJobFlavor.Inf2x6,
                "l40sx1" => CreateSettingsWebhooksRequestJobFlavor.L40sx1,
                "l40sx4" => CreateSettingsWebhooksRequestJobFlavor.L40sx4,
                "l40sx8" => CreateSettingsWebhooksRequestJobFlavor.L40sx8,
                "l4x1" => CreateSettingsWebhooksRequestJobFlavor.L4x1,
                "l4x4" => CreateSettingsWebhooksRequestJobFlavor.L4x4,
                "sprx8" => CreateSettingsWebhooksRequestJobFlavor.Sprx8,
                "t4-medium" => CreateSettingsWebhooksRequestJobFlavor.T4Medium,
                "t4-small" => CreateSettingsWebhooksRequestJobFlavor.T4Small,
                "zero-a10g" => CreateSettingsWebhooksRequestJobFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}