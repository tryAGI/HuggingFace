
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseJobSpecFlavor
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
    public static class ResponseJobSpecFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseJobSpecFlavor value)
        {
            return value switch
            {
                ResponseJobSpecFlavor.CpuBasic => "cpu-basic",
                ResponseJobSpecFlavor.CpuUpgrade => "cpu-upgrade",
                ResponseJobSpecFlavor.CpuPerformance => "cpu-performance",
                ResponseJobSpecFlavor.CpuXl => "cpu-xl",
                ResponseJobSpecFlavor.Sprx8 => "sprx8",
                ResponseJobSpecFlavor.ZeroA10g => "zero-a10g",
                ResponseJobSpecFlavor.T4Small => "t4-small",
                ResponseJobSpecFlavor.T4Medium => "t4-medium",
                ResponseJobSpecFlavor.L4x1 => "l4x1",
                ResponseJobSpecFlavor.L4x4 => "l4x4",
                ResponseJobSpecFlavor.L40sx1 => "l40sx1",
                ResponseJobSpecFlavor.L40sx4 => "l40sx4",
                ResponseJobSpecFlavor.L40sx8 => "l40sx8",
                ResponseJobSpecFlavor.A10gSmall => "a10g-small",
                ResponseJobSpecFlavor.A10gLarge => "a10g-large",
                ResponseJobSpecFlavor.A10gLargex2 => "a10g-largex2",
                ResponseJobSpecFlavor.A10gLargex4 => "a10g-largex4",
                ResponseJobSpecFlavor.A100Large => "a100-large",
                ResponseJobSpecFlavor.A100x4 => "a100x4",
                ResponseJobSpecFlavor.A100x8 => "a100x8",
                ResponseJobSpecFlavor.H200 => "h200",
                ResponseJobSpecFlavor.H200x2 => "h200x2",
                ResponseJobSpecFlavor.H200x4 => "h200x4",
                ResponseJobSpecFlavor.H200x8 => "h200x8",
                ResponseJobSpecFlavor.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseJobSpecFlavor? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => ResponseJobSpecFlavor.CpuBasic,
                "cpu-upgrade" => ResponseJobSpecFlavor.CpuUpgrade,
                "cpu-performance" => ResponseJobSpecFlavor.CpuPerformance,
                "cpu-xl" => ResponseJobSpecFlavor.CpuXl,
                "sprx8" => ResponseJobSpecFlavor.Sprx8,
                "zero-a10g" => ResponseJobSpecFlavor.ZeroA10g,
                "t4-small" => ResponseJobSpecFlavor.T4Small,
                "t4-medium" => ResponseJobSpecFlavor.T4Medium,
                "l4x1" => ResponseJobSpecFlavor.L4x1,
                "l4x4" => ResponseJobSpecFlavor.L4x4,
                "l40sx1" => ResponseJobSpecFlavor.L40sx1,
                "l40sx4" => ResponseJobSpecFlavor.L40sx4,
                "l40sx8" => ResponseJobSpecFlavor.L40sx8,
                "a10g-small" => ResponseJobSpecFlavor.A10gSmall,
                "a10g-large" => ResponseJobSpecFlavor.A10gLarge,
                "a10g-largex2" => ResponseJobSpecFlavor.A10gLargex2,
                "a10g-largex4" => ResponseJobSpecFlavor.A10gLargex4,
                "a100-large" => ResponseJobSpecFlavor.A100Large,
                "a100x4" => ResponseJobSpecFlavor.A100x4,
                "a100x8" => ResponseJobSpecFlavor.A100x8,
                "h200" => ResponseJobSpecFlavor.H200,
                "h200x2" => ResponseJobSpecFlavor.H200x2,
                "h200x4" => ResponseJobSpecFlavor.H200x4,
                "h200x8" => ResponseJobSpecFlavor.H200x8,
                "inf2x6" => ResponseJobSpecFlavor.Inf2x6,
                _ => null,
            };
        }
    }
}