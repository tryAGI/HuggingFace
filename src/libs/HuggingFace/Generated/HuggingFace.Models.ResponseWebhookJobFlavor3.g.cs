
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseWebhookJobFlavor3
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
    public static class ResponseWebhookJobFlavor3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebhookJobFlavor3 value)
        {
            return value switch
            {
                ResponseWebhookJobFlavor3.CpuBasic => "cpu-basic",
                ResponseWebhookJobFlavor3.CpuUpgrade => "cpu-upgrade",
                ResponseWebhookJobFlavor3.CpuPerformance => "cpu-performance",
                ResponseWebhookJobFlavor3.CpuXl => "cpu-xl",
                ResponseWebhookJobFlavor3.Sprx8 => "sprx8",
                ResponseWebhookJobFlavor3.ZeroA10g => "zero-a10g",
                ResponseWebhookJobFlavor3.T4Small => "t4-small",
                ResponseWebhookJobFlavor3.T4Medium => "t4-medium",
                ResponseWebhookJobFlavor3.L4x1 => "l4x1",
                ResponseWebhookJobFlavor3.L4x4 => "l4x4",
                ResponseWebhookJobFlavor3.L40sx1 => "l40sx1",
                ResponseWebhookJobFlavor3.L40sx4 => "l40sx4",
                ResponseWebhookJobFlavor3.L40sx8 => "l40sx8",
                ResponseWebhookJobFlavor3.A10gSmall => "a10g-small",
                ResponseWebhookJobFlavor3.A10gLarge => "a10g-large",
                ResponseWebhookJobFlavor3.A10gLargex2 => "a10g-largex2",
                ResponseWebhookJobFlavor3.A10gLargex4 => "a10g-largex4",
                ResponseWebhookJobFlavor3.A100Large => "a100-large",
                ResponseWebhookJobFlavor3.A100x4 => "a100x4",
                ResponseWebhookJobFlavor3.A100x8 => "a100x8",
                ResponseWebhookJobFlavor3.H200 => "h200",
                ResponseWebhookJobFlavor3.H200x2 => "h200x2",
                ResponseWebhookJobFlavor3.H200x4 => "h200x4",
                ResponseWebhookJobFlavor3.H200x8 => "h200x8",
                ResponseWebhookJobFlavor3.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebhookJobFlavor3? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => ResponseWebhookJobFlavor3.CpuBasic,
                "cpu-upgrade" => ResponseWebhookJobFlavor3.CpuUpgrade,
                "cpu-performance" => ResponseWebhookJobFlavor3.CpuPerformance,
                "cpu-xl" => ResponseWebhookJobFlavor3.CpuXl,
                "sprx8" => ResponseWebhookJobFlavor3.Sprx8,
                "zero-a10g" => ResponseWebhookJobFlavor3.ZeroA10g,
                "t4-small" => ResponseWebhookJobFlavor3.T4Small,
                "t4-medium" => ResponseWebhookJobFlavor3.T4Medium,
                "l4x1" => ResponseWebhookJobFlavor3.L4x1,
                "l4x4" => ResponseWebhookJobFlavor3.L4x4,
                "l40sx1" => ResponseWebhookJobFlavor3.L40sx1,
                "l40sx4" => ResponseWebhookJobFlavor3.L40sx4,
                "l40sx8" => ResponseWebhookJobFlavor3.L40sx8,
                "a10g-small" => ResponseWebhookJobFlavor3.A10gSmall,
                "a10g-large" => ResponseWebhookJobFlavor3.A10gLarge,
                "a10g-largex2" => ResponseWebhookJobFlavor3.A10gLargex2,
                "a10g-largex4" => ResponseWebhookJobFlavor3.A10gLargex4,
                "a100-large" => ResponseWebhookJobFlavor3.A100Large,
                "a100x4" => ResponseWebhookJobFlavor3.A100x4,
                "a100x8" => ResponseWebhookJobFlavor3.A100x8,
                "h200" => ResponseWebhookJobFlavor3.H200,
                "h200x2" => ResponseWebhookJobFlavor3.H200x2,
                "h200x4" => ResponseWebhookJobFlavor3.H200x4,
                "h200x8" => ResponseWebhookJobFlavor3.H200x8,
                "inf2x6" => ResponseWebhookJobFlavor3.Inf2x6,
                _ => null,
            };
        }
    }
}