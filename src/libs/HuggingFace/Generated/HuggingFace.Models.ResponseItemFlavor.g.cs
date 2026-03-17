
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemFlavor
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
    public static class ResponseItemFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemFlavor value)
        {
            return value switch
            {
                ResponseItemFlavor.CpuBasic => "cpu-basic",
                ResponseItemFlavor.CpuUpgrade => "cpu-upgrade",
                ResponseItemFlavor.CpuPerformance => "cpu-performance",
                ResponseItemFlavor.CpuXl => "cpu-xl",
                ResponseItemFlavor.Sprx8 => "sprx8",
                ResponseItemFlavor.ZeroA10g => "zero-a10g",
                ResponseItemFlavor.T4Small => "t4-small",
                ResponseItemFlavor.T4Medium => "t4-medium",
                ResponseItemFlavor.L4x1 => "l4x1",
                ResponseItemFlavor.L4x4 => "l4x4",
                ResponseItemFlavor.L40sx1 => "l40sx1",
                ResponseItemFlavor.L40sx4 => "l40sx4",
                ResponseItemFlavor.L40sx8 => "l40sx8",
                ResponseItemFlavor.A10gSmall => "a10g-small",
                ResponseItemFlavor.A10gLarge => "a10g-large",
                ResponseItemFlavor.A10gLargex2 => "a10g-largex2",
                ResponseItemFlavor.A10gLargex4 => "a10g-largex4",
                ResponseItemFlavor.A100Large => "a100-large",
                ResponseItemFlavor.A100x4 => "a100x4",
                ResponseItemFlavor.A100x8 => "a100x8",
                ResponseItemFlavor.H200 => "h200",
                ResponseItemFlavor.H200x2 => "h200x2",
                ResponseItemFlavor.H200x4 => "h200x4",
                ResponseItemFlavor.H200x8 => "h200x8",
                ResponseItemFlavor.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemFlavor? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => ResponseItemFlavor.CpuBasic,
                "cpu-upgrade" => ResponseItemFlavor.CpuUpgrade,
                "cpu-performance" => ResponseItemFlavor.CpuPerformance,
                "cpu-xl" => ResponseItemFlavor.CpuXl,
                "sprx8" => ResponseItemFlavor.Sprx8,
                "zero-a10g" => ResponseItemFlavor.ZeroA10g,
                "t4-small" => ResponseItemFlavor.T4Small,
                "t4-medium" => ResponseItemFlavor.T4Medium,
                "l4x1" => ResponseItemFlavor.L4x1,
                "l4x4" => ResponseItemFlavor.L4x4,
                "l40sx1" => ResponseItemFlavor.L40sx1,
                "l40sx4" => ResponseItemFlavor.L40sx4,
                "l40sx8" => ResponseItemFlavor.L40sx8,
                "a10g-small" => ResponseItemFlavor.A10gSmall,
                "a10g-large" => ResponseItemFlavor.A10gLarge,
                "a10g-largex2" => ResponseItemFlavor.A10gLargex2,
                "a10g-largex4" => ResponseItemFlavor.A10gLargex4,
                "a100-large" => ResponseItemFlavor.A100Large,
                "a100x4" => ResponseItemFlavor.A100x4,
                "a100x8" => ResponseItemFlavor.A100x8,
                "h200" => ResponseItemFlavor.H200,
                "h200x2" => ResponseItemFlavor.H200x2,
                "h200x4" => ResponseItemFlavor.H200x4,
                "h200x8" => ResponseItemFlavor.H200x8,
                "inf2x6" => ResponseItemFlavor.Inf2x6,
                _ => null,
            };
        }
    }
}