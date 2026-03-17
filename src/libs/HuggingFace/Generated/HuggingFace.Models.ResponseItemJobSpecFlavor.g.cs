
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemJobSpecFlavor
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
    public static class ResponseItemJobSpecFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemJobSpecFlavor value)
        {
            return value switch
            {
                ResponseItemJobSpecFlavor.CpuBasic => "cpu-basic",
                ResponseItemJobSpecFlavor.CpuUpgrade => "cpu-upgrade",
                ResponseItemJobSpecFlavor.CpuPerformance => "cpu-performance",
                ResponseItemJobSpecFlavor.CpuXl => "cpu-xl",
                ResponseItemJobSpecFlavor.Sprx8 => "sprx8",
                ResponseItemJobSpecFlavor.ZeroA10g => "zero-a10g",
                ResponseItemJobSpecFlavor.T4Small => "t4-small",
                ResponseItemJobSpecFlavor.T4Medium => "t4-medium",
                ResponseItemJobSpecFlavor.L4x1 => "l4x1",
                ResponseItemJobSpecFlavor.L4x4 => "l4x4",
                ResponseItemJobSpecFlavor.L40sx1 => "l40sx1",
                ResponseItemJobSpecFlavor.L40sx4 => "l40sx4",
                ResponseItemJobSpecFlavor.L40sx8 => "l40sx8",
                ResponseItemJobSpecFlavor.A10gSmall => "a10g-small",
                ResponseItemJobSpecFlavor.A10gLarge => "a10g-large",
                ResponseItemJobSpecFlavor.A10gLargex2 => "a10g-largex2",
                ResponseItemJobSpecFlavor.A10gLargex4 => "a10g-largex4",
                ResponseItemJobSpecFlavor.A100Large => "a100-large",
                ResponseItemJobSpecFlavor.A100x4 => "a100x4",
                ResponseItemJobSpecFlavor.A100x8 => "a100x8",
                ResponseItemJobSpecFlavor.H200 => "h200",
                ResponseItemJobSpecFlavor.H200x2 => "h200x2",
                ResponseItemJobSpecFlavor.H200x4 => "h200x4",
                ResponseItemJobSpecFlavor.H200x8 => "h200x8",
                ResponseItemJobSpecFlavor.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemJobSpecFlavor? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => ResponseItemJobSpecFlavor.CpuBasic,
                "cpu-upgrade" => ResponseItemJobSpecFlavor.CpuUpgrade,
                "cpu-performance" => ResponseItemJobSpecFlavor.CpuPerformance,
                "cpu-xl" => ResponseItemJobSpecFlavor.CpuXl,
                "sprx8" => ResponseItemJobSpecFlavor.Sprx8,
                "zero-a10g" => ResponseItemJobSpecFlavor.ZeroA10g,
                "t4-small" => ResponseItemJobSpecFlavor.T4Small,
                "t4-medium" => ResponseItemJobSpecFlavor.T4Medium,
                "l4x1" => ResponseItemJobSpecFlavor.L4x1,
                "l4x4" => ResponseItemJobSpecFlavor.L4x4,
                "l40sx1" => ResponseItemJobSpecFlavor.L40sx1,
                "l40sx4" => ResponseItemJobSpecFlavor.L40sx4,
                "l40sx8" => ResponseItemJobSpecFlavor.L40sx8,
                "a10g-small" => ResponseItemJobSpecFlavor.A10gSmall,
                "a10g-large" => ResponseItemJobSpecFlavor.A10gLarge,
                "a10g-largex2" => ResponseItemJobSpecFlavor.A10gLargex2,
                "a10g-largex4" => ResponseItemJobSpecFlavor.A10gLargex4,
                "a100-large" => ResponseItemJobSpecFlavor.A100Large,
                "a100x4" => ResponseItemJobSpecFlavor.A100x4,
                "a100x8" => ResponseItemJobSpecFlavor.A100x8,
                "h200" => ResponseItemJobSpecFlavor.H200,
                "h200x2" => ResponseItemJobSpecFlavor.H200x2,
                "h200x4" => ResponseItemJobSpecFlavor.H200x4,
                "h200x8" => ResponseItemJobSpecFlavor.H200x8,
                "inf2x6" => ResponseItemJobSpecFlavor.Inf2x6,
                _ => null,
            };
        }
    }
}