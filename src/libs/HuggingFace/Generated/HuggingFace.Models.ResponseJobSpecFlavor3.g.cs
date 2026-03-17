
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseJobSpecFlavor3
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
    public static class ResponseJobSpecFlavor3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseJobSpecFlavor3 value)
        {
            return value switch
            {
                ResponseJobSpecFlavor3.CpuBasic => "cpu-basic",
                ResponseJobSpecFlavor3.CpuUpgrade => "cpu-upgrade",
                ResponseJobSpecFlavor3.CpuPerformance => "cpu-performance",
                ResponseJobSpecFlavor3.CpuXl => "cpu-xl",
                ResponseJobSpecFlavor3.Sprx8 => "sprx8",
                ResponseJobSpecFlavor3.ZeroA10g => "zero-a10g",
                ResponseJobSpecFlavor3.T4Small => "t4-small",
                ResponseJobSpecFlavor3.T4Medium => "t4-medium",
                ResponseJobSpecFlavor3.L4x1 => "l4x1",
                ResponseJobSpecFlavor3.L4x4 => "l4x4",
                ResponseJobSpecFlavor3.L40sx1 => "l40sx1",
                ResponseJobSpecFlavor3.L40sx4 => "l40sx4",
                ResponseJobSpecFlavor3.L40sx8 => "l40sx8",
                ResponseJobSpecFlavor3.A10gSmall => "a10g-small",
                ResponseJobSpecFlavor3.A10gLarge => "a10g-large",
                ResponseJobSpecFlavor3.A10gLargex2 => "a10g-largex2",
                ResponseJobSpecFlavor3.A10gLargex4 => "a10g-largex4",
                ResponseJobSpecFlavor3.A100Large => "a100-large",
                ResponseJobSpecFlavor3.A100x4 => "a100x4",
                ResponseJobSpecFlavor3.A100x8 => "a100x8",
                ResponseJobSpecFlavor3.H200 => "h200",
                ResponseJobSpecFlavor3.H200x2 => "h200x2",
                ResponseJobSpecFlavor3.H200x4 => "h200x4",
                ResponseJobSpecFlavor3.H200x8 => "h200x8",
                ResponseJobSpecFlavor3.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseJobSpecFlavor3? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => ResponseJobSpecFlavor3.CpuBasic,
                "cpu-upgrade" => ResponseJobSpecFlavor3.CpuUpgrade,
                "cpu-performance" => ResponseJobSpecFlavor3.CpuPerformance,
                "cpu-xl" => ResponseJobSpecFlavor3.CpuXl,
                "sprx8" => ResponseJobSpecFlavor3.Sprx8,
                "zero-a10g" => ResponseJobSpecFlavor3.ZeroA10g,
                "t4-small" => ResponseJobSpecFlavor3.T4Small,
                "t4-medium" => ResponseJobSpecFlavor3.T4Medium,
                "l4x1" => ResponseJobSpecFlavor3.L4x1,
                "l4x4" => ResponseJobSpecFlavor3.L4x4,
                "l40sx1" => ResponseJobSpecFlavor3.L40sx1,
                "l40sx4" => ResponseJobSpecFlavor3.L40sx4,
                "l40sx8" => ResponseJobSpecFlavor3.L40sx8,
                "a10g-small" => ResponseJobSpecFlavor3.A10gSmall,
                "a10g-large" => ResponseJobSpecFlavor3.A10gLarge,
                "a10g-largex2" => ResponseJobSpecFlavor3.A10gLargex2,
                "a10g-largex4" => ResponseJobSpecFlavor3.A10gLargex4,
                "a100-large" => ResponseJobSpecFlavor3.A100Large,
                "a100x4" => ResponseJobSpecFlavor3.A100x4,
                "a100x8" => ResponseJobSpecFlavor3.A100x8,
                "h200" => ResponseJobSpecFlavor3.H200,
                "h200x2" => ResponseJobSpecFlavor3.H200x2,
                "h200x4" => ResponseJobSpecFlavor3.H200x4,
                "h200x8" => ResponseJobSpecFlavor3.H200x8,
                "inf2x6" => ResponseJobSpecFlavor3.Inf2x6,
                _ => null,
            };
        }
    }
}