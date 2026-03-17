
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseWebhookJobFlavor4
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
    public static class ResponseWebhookJobFlavor4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebhookJobFlavor4 value)
        {
            return value switch
            {
                ResponseWebhookJobFlavor4.CpuBasic => "cpu-basic",
                ResponseWebhookJobFlavor4.CpuUpgrade => "cpu-upgrade",
                ResponseWebhookJobFlavor4.CpuPerformance => "cpu-performance",
                ResponseWebhookJobFlavor4.CpuXl => "cpu-xl",
                ResponseWebhookJobFlavor4.Sprx8 => "sprx8",
                ResponseWebhookJobFlavor4.ZeroA10g => "zero-a10g",
                ResponseWebhookJobFlavor4.T4Small => "t4-small",
                ResponseWebhookJobFlavor4.T4Medium => "t4-medium",
                ResponseWebhookJobFlavor4.L4x1 => "l4x1",
                ResponseWebhookJobFlavor4.L4x4 => "l4x4",
                ResponseWebhookJobFlavor4.L40sx1 => "l40sx1",
                ResponseWebhookJobFlavor4.L40sx4 => "l40sx4",
                ResponseWebhookJobFlavor4.L40sx8 => "l40sx8",
                ResponseWebhookJobFlavor4.A10gSmall => "a10g-small",
                ResponseWebhookJobFlavor4.A10gLarge => "a10g-large",
                ResponseWebhookJobFlavor4.A10gLargex2 => "a10g-largex2",
                ResponseWebhookJobFlavor4.A10gLargex4 => "a10g-largex4",
                ResponseWebhookJobFlavor4.A100Large => "a100-large",
                ResponseWebhookJobFlavor4.A100x4 => "a100x4",
                ResponseWebhookJobFlavor4.A100x8 => "a100x8",
                ResponseWebhookJobFlavor4.H200 => "h200",
                ResponseWebhookJobFlavor4.H200x2 => "h200x2",
                ResponseWebhookJobFlavor4.H200x4 => "h200x4",
                ResponseWebhookJobFlavor4.H200x8 => "h200x8",
                ResponseWebhookJobFlavor4.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebhookJobFlavor4? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => ResponseWebhookJobFlavor4.CpuBasic,
                "cpu-upgrade" => ResponseWebhookJobFlavor4.CpuUpgrade,
                "cpu-performance" => ResponseWebhookJobFlavor4.CpuPerformance,
                "cpu-xl" => ResponseWebhookJobFlavor4.CpuXl,
                "sprx8" => ResponseWebhookJobFlavor4.Sprx8,
                "zero-a10g" => ResponseWebhookJobFlavor4.ZeroA10g,
                "t4-small" => ResponseWebhookJobFlavor4.T4Small,
                "t4-medium" => ResponseWebhookJobFlavor4.T4Medium,
                "l4x1" => ResponseWebhookJobFlavor4.L4x1,
                "l4x4" => ResponseWebhookJobFlavor4.L4x4,
                "l40sx1" => ResponseWebhookJobFlavor4.L40sx1,
                "l40sx4" => ResponseWebhookJobFlavor4.L40sx4,
                "l40sx8" => ResponseWebhookJobFlavor4.L40sx8,
                "a10g-small" => ResponseWebhookJobFlavor4.A10gSmall,
                "a10g-large" => ResponseWebhookJobFlavor4.A10gLarge,
                "a10g-largex2" => ResponseWebhookJobFlavor4.A10gLargex2,
                "a10g-largex4" => ResponseWebhookJobFlavor4.A10gLargex4,
                "a100-large" => ResponseWebhookJobFlavor4.A100Large,
                "a100x4" => ResponseWebhookJobFlavor4.A100x4,
                "a100x8" => ResponseWebhookJobFlavor4.A100x8,
                "h200" => ResponseWebhookJobFlavor4.H200,
                "h200x2" => ResponseWebhookJobFlavor4.H200x2,
                "h200x4" => ResponseWebhookJobFlavor4.H200x4,
                "h200x8" => ResponseWebhookJobFlavor4.H200x8,
                "inf2x6" => ResponseWebhookJobFlavor4.Inf2x6,
                _ => null,
            };
        }
    }
}