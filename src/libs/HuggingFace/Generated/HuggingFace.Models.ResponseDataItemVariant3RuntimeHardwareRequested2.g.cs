
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3RuntimeHardwareRequested2
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
    public static class ResponseDataItemVariant3RuntimeHardwareRequested2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3RuntimeHardwareRequested2 value)
        {
            return value switch
            {
                ResponseDataItemVariant3RuntimeHardwareRequested2.CpuBasic => "cpu-basic",
                ResponseDataItemVariant3RuntimeHardwareRequested2.CpuUpgrade => "cpu-upgrade",
                ResponseDataItemVariant3RuntimeHardwareRequested2.CpuPerformance => "cpu-performance",
                ResponseDataItemVariant3RuntimeHardwareRequested2.CpuXl => "cpu-xl",
                ResponseDataItemVariant3RuntimeHardwareRequested2.Sprx8 => "sprx8",
                ResponseDataItemVariant3RuntimeHardwareRequested2.ZeroA10g => "zero-a10g",
                ResponseDataItemVariant3RuntimeHardwareRequested2.T4Small => "t4-small",
                ResponseDataItemVariant3RuntimeHardwareRequested2.T4Medium => "t4-medium",
                ResponseDataItemVariant3RuntimeHardwareRequested2.L4x1 => "l4x1",
                ResponseDataItemVariant3RuntimeHardwareRequested2.L4x4 => "l4x4",
                ResponseDataItemVariant3RuntimeHardwareRequested2.L40sx1 => "l40sx1",
                ResponseDataItemVariant3RuntimeHardwareRequested2.L40sx4 => "l40sx4",
                ResponseDataItemVariant3RuntimeHardwareRequested2.L40sx8 => "l40sx8",
                ResponseDataItemVariant3RuntimeHardwareRequested2.A10gSmall => "a10g-small",
                ResponseDataItemVariant3RuntimeHardwareRequested2.A10gLarge => "a10g-large",
                ResponseDataItemVariant3RuntimeHardwareRequested2.A10gLargex2 => "a10g-largex2",
                ResponseDataItemVariant3RuntimeHardwareRequested2.A10gLargex4 => "a10g-largex4",
                ResponseDataItemVariant3RuntimeHardwareRequested2.A100Large => "a100-large",
                ResponseDataItemVariant3RuntimeHardwareRequested2.A100x4 => "a100x4",
                ResponseDataItemVariant3RuntimeHardwareRequested2.A100x8 => "a100x8",
                ResponseDataItemVariant3RuntimeHardwareRequested2.H200 => "h200",
                ResponseDataItemVariant3RuntimeHardwareRequested2.H200x2 => "h200x2",
                ResponseDataItemVariant3RuntimeHardwareRequested2.H200x4 => "h200x4",
                ResponseDataItemVariant3RuntimeHardwareRequested2.H200x8 => "h200x8",
                ResponseDataItemVariant3RuntimeHardwareRequested2.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3RuntimeHardwareRequested2? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => ResponseDataItemVariant3RuntimeHardwareRequested2.CpuBasic,
                "cpu-upgrade" => ResponseDataItemVariant3RuntimeHardwareRequested2.CpuUpgrade,
                "cpu-performance" => ResponseDataItemVariant3RuntimeHardwareRequested2.CpuPerformance,
                "cpu-xl" => ResponseDataItemVariant3RuntimeHardwareRequested2.CpuXl,
                "sprx8" => ResponseDataItemVariant3RuntimeHardwareRequested2.Sprx8,
                "zero-a10g" => ResponseDataItemVariant3RuntimeHardwareRequested2.ZeroA10g,
                "t4-small" => ResponseDataItemVariant3RuntimeHardwareRequested2.T4Small,
                "t4-medium" => ResponseDataItemVariant3RuntimeHardwareRequested2.T4Medium,
                "l4x1" => ResponseDataItemVariant3RuntimeHardwareRequested2.L4x1,
                "l4x4" => ResponseDataItemVariant3RuntimeHardwareRequested2.L4x4,
                "l40sx1" => ResponseDataItemVariant3RuntimeHardwareRequested2.L40sx1,
                "l40sx4" => ResponseDataItemVariant3RuntimeHardwareRequested2.L40sx4,
                "l40sx8" => ResponseDataItemVariant3RuntimeHardwareRequested2.L40sx8,
                "a10g-small" => ResponseDataItemVariant3RuntimeHardwareRequested2.A10gSmall,
                "a10g-large" => ResponseDataItemVariant3RuntimeHardwareRequested2.A10gLarge,
                "a10g-largex2" => ResponseDataItemVariant3RuntimeHardwareRequested2.A10gLargex2,
                "a10g-largex4" => ResponseDataItemVariant3RuntimeHardwareRequested2.A10gLargex4,
                "a100-large" => ResponseDataItemVariant3RuntimeHardwareRequested2.A100Large,
                "a100x4" => ResponseDataItemVariant3RuntimeHardwareRequested2.A100x4,
                "a100x8" => ResponseDataItemVariant3RuntimeHardwareRequested2.A100x8,
                "h200" => ResponseDataItemVariant3RuntimeHardwareRequested2.H200,
                "h200x2" => ResponseDataItemVariant3RuntimeHardwareRequested2.H200x2,
                "h200x4" => ResponseDataItemVariant3RuntimeHardwareRequested2.H200x4,
                "h200x8" => ResponseDataItemVariant3RuntimeHardwareRequested2.H200x8,
                "inf2x6" => ResponseDataItemVariant3RuntimeHardwareRequested2.Inf2x6,
                _ => null,
            };
        }
    }
}