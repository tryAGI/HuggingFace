
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFlavor
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
    public static class ResponseFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFlavor value)
        {
            return value switch
            {
                ResponseFlavor.CpuBasic => "cpu-basic",
                ResponseFlavor.CpuUpgrade => "cpu-upgrade",
                ResponseFlavor.CpuPerformance => "cpu-performance",
                ResponseFlavor.CpuXl => "cpu-xl",
                ResponseFlavor.Sprx8 => "sprx8",
                ResponseFlavor.ZeroA10g => "zero-a10g",
                ResponseFlavor.T4Small => "t4-small",
                ResponseFlavor.T4Medium => "t4-medium",
                ResponseFlavor.L4x1 => "l4x1",
                ResponseFlavor.L4x4 => "l4x4",
                ResponseFlavor.L40sx1 => "l40sx1",
                ResponseFlavor.L40sx4 => "l40sx4",
                ResponseFlavor.L40sx8 => "l40sx8",
                ResponseFlavor.A10gSmall => "a10g-small",
                ResponseFlavor.A10gLarge => "a10g-large",
                ResponseFlavor.A10gLargex2 => "a10g-largex2",
                ResponseFlavor.A10gLargex4 => "a10g-largex4",
                ResponseFlavor.A100Large => "a100-large",
                ResponseFlavor.A100x4 => "a100x4",
                ResponseFlavor.A100x8 => "a100x8",
                ResponseFlavor.H200 => "h200",
                ResponseFlavor.H200x2 => "h200x2",
                ResponseFlavor.H200x4 => "h200x4",
                ResponseFlavor.H200x8 => "h200x8",
                ResponseFlavor.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFlavor? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => ResponseFlavor.CpuBasic,
                "cpu-upgrade" => ResponseFlavor.CpuUpgrade,
                "cpu-performance" => ResponseFlavor.CpuPerformance,
                "cpu-xl" => ResponseFlavor.CpuXl,
                "sprx8" => ResponseFlavor.Sprx8,
                "zero-a10g" => ResponseFlavor.ZeroA10g,
                "t4-small" => ResponseFlavor.T4Small,
                "t4-medium" => ResponseFlavor.T4Medium,
                "l4x1" => ResponseFlavor.L4x1,
                "l4x4" => ResponseFlavor.L4x4,
                "l40sx1" => ResponseFlavor.L40sx1,
                "l40sx4" => ResponseFlavor.L40sx4,
                "l40sx8" => ResponseFlavor.L40sx8,
                "a10g-small" => ResponseFlavor.A10gSmall,
                "a10g-large" => ResponseFlavor.A10gLarge,
                "a10g-largex2" => ResponseFlavor.A10gLargex2,
                "a10g-largex4" => ResponseFlavor.A10gLargex4,
                "a100-large" => ResponseFlavor.A100Large,
                "a100x4" => ResponseFlavor.A100x4,
                "a100x8" => ResponseFlavor.A100x8,
                "h200" => ResponseFlavor.H200,
                "h200x2" => ResponseFlavor.H200x2,
                "h200x4" => ResponseFlavor.H200x4,
                "h200x8" => ResponseFlavor.H200x8,
                "inf2x6" => ResponseFlavor.Inf2x6,
                _ => null,
            };
        }
    }
}