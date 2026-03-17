
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3RuntimeHardwareCurrent2
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
    public static class ResponseItemVariant3RuntimeHardwareCurrent2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3RuntimeHardwareCurrent2 value)
        {
            return value switch
            {
                ResponseItemVariant3RuntimeHardwareCurrent2.CpuBasic => "cpu-basic",
                ResponseItemVariant3RuntimeHardwareCurrent2.CpuUpgrade => "cpu-upgrade",
                ResponseItemVariant3RuntimeHardwareCurrent2.CpuPerformance => "cpu-performance",
                ResponseItemVariant3RuntimeHardwareCurrent2.CpuXl => "cpu-xl",
                ResponseItemVariant3RuntimeHardwareCurrent2.Sprx8 => "sprx8",
                ResponseItemVariant3RuntimeHardwareCurrent2.ZeroA10g => "zero-a10g",
                ResponseItemVariant3RuntimeHardwareCurrent2.T4Small => "t4-small",
                ResponseItemVariant3RuntimeHardwareCurrent2.T4Medium => "t4-medium",
                ResponseItemVariant3RuntimeHardwareCurrent2.L4x1 => "l4x1",
                ResponseItemVariant3RuntimeHardwareCurrent2.L4x4 => "l4x4",
                ResponseItemVariant3RuntimeHardwareCurrent2.L40sx1 => "l40sx1",
                ResponseItemVariant3RuntimeHardwareCurrent2.L40sx4 => "l40sx4",
                ResponseItemVariant3RuntimeHardwareCurrent2.L40sx8 => "l40sx8",
                ResponseItemVariant3RuntimeHardwareCurrent2.A10gSmall => "a10g-small",
                ResponseItemVariant3RuntimeHardwareCurrent2.A10gLarge => "a10g-large",
                ResponseItemVariant3RuntimeHardwareCurrent2.A10gLargex2 => "a10g-largex2",
                ResponseItemVariant3RuntimeHardwareCurrent2.A10gLargex4 => "a10g-largex4",
                ResponseItemVariant3RuntimeHardwareCurrent2.A100Large => "a100-large",
                ResponseItemVariant3RuntimeHardwareCurrent2.A100x4 => "a100x4",
                ResponseItemVariant3RuntimeHardwareCurrent2.A100x8 => "a100x8",
                ResponseItemVariant3RuntimeHardwareCurrent2.H200 => "h200",
                ResponseItemVariant3RuntimeHardwareCurrent2.H200x2 => "h200x2",
                ResponseItemVariant3RuntimeHardwareCurrent2.H200x4 => "h200x4",
                ResponseItemVariant3RuntimeHardwareCurrent2.H200x8 => "h200x8",
                ResponseItemVariant3RuntimeHardwareCurrent2.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3RuntimeHardwareCurrent2? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => ResponseItemVariant3RuntimeHardwareCurrent2.CpuBasic,
                "cpu-upgrade" => ResponseItemVariant3RuntimeHardwareCurrent2.CpuUpgrade,
                "cpu-performance" => ResponseItemVariant3RuntimeHardwareCurrent2.CpuPerformance,
                "cpu-xl" => ResponseItemVariant3RuntimeHardwareCurrent2.CpuXl,
                "sprx8" => ResponseItemVariant3RuntimeHardwareCurrent2.Sprx8,
                "zero-a10g" => ResponseItemVariant3RuntimeHardwareCurrent2.ZeroA10g,
                "t4-small" => ResponseItemVariant3RuntimeHardwareCurrent2.T4Small,
                "t4-medium" => ResponseItemVariant3RuntimeHardwareCurrent2.T4Medium,
                "l4x1" => ResponseItemVariant3RuntimeHardwareCurrent2.L4x1,
                "l4x4" => ResponseItemVariant3RuntimeHardwareCurrent2.L4x4,
                "l40sx1" => ResponseItemVariant3RuntimeHardwareCurrent2.L40sx1,
                "l40sx4" => ResponseItemVariant3RuntimeHardwareCurrent2.L40sx4,
                "l40sx8" => ResponseItemVariant3RuntimeHardwareCurrent2.L40sx8,
                "a10g-small" => ResponseItemVariant3RuntimeHardwareCurrent2.A10gSmall,
                "a10g-large" => ResponseItemVariant3RuntimeHardwareCurrent2.A10gLarge,
                "a10g-largex2" => ResponseItemVariant3RuntimeHardwareCurrent2.A10gLargex2,
                "a10g-largex4" => ResponseItemVariant3RuntimeHardwareCurrent2.A10gLargex4,
                "a100-large" => ResponseItemVariant3RuntimeHardwareCurrent2.A100Large,
                "a100x4" => ResponseItemVariant3RuntimeHardwareCurrent2.A100x4,
                "a100x8" => ResponseItemVariant3RuntimeHardwareCurrent2.A100x8,
                "h200" => ResponseItemVariant3RuntimeHardwareCurrent2.H200,
                "h200x2" => ResponseItemVariant3RuntimeHardwareCurrent2.H200x2,
                "h200x4" => ResponseItemVariant3RuntimeHardwareCurrent2.H200x4,
                "h200x8" => ResponseItemVariant3RuntimeHardwareCurrent2.H200x8,
                "inf2x6" => ResponseItemVariant3RuntimeHardwareCurrent2.Inf2x6,
                _ => null,
            };
        }
    }
}