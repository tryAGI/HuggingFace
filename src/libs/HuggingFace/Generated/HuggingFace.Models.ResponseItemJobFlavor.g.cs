
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemJobFlavor
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
    public static class ResponseItemJobFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemJobFlavor value)
        {
            return value switch
            {
                ResponseItemJobFlavor.CpuBasic => "cpu-basic",
                ResponseItemJobFlavor.CpuUpgrade => "cpu-upgrade",
                ResponseItemJobFlavor.CpuPerformance => "cpu-performance",
                ResponseItemJobFlavor.CpuXl => "cpu-xl",
                ResponseItemJobFlavor.Sprx8 => "sprx8",
                ResponseItemJobFlavor.ZeroA10g => "zero-a10g",
                ResponseItemJobFlavor.T4Small => "t4-small",
                ResponseItemJobFlavor.T4Medium => "t4-medium",
                ResponseItemJobFlavor.L4x1 => "l4x1",
                ResponseItemJobFlavor.L4x4 => "l4x4",
                ResponseItemJobFlavor.L40sx1 => "l40sx1",
                ResponseItemJobFlavor.L40sx4 => "l40sx4",
                ResponseItemJobFlavor.L40sx8 => "l40sx8",
                ResponseItemJobFlavor.A10gSmall => "a10g-small",
                ResponseItemJobFlavor.A10gLarge => "a10g-large",
                ResponseItemJobFlavor.A10gLargex2 => "a10g-largex2",
                ResponseItemJobFlavor.A10gLargex4 => "a10g-largex4",
                ResponseItemJobFlavor.A100Large => "a100-large",
                ResponseItemJobFlavor.A100x4 => "a100x4",
                ResponseItemJobFlavor.A100x8 => "a100x8",
                ResponseItemJobFlavor.H200 => "h200",
                ResponseItemJobFlavor.H200x2 => "h200x2",
                ResponseItemJobFlavor.H200x4 => "h200x4",
                ResponseItemJobFlavor.H200x8 => "h200x8",
                ResponseItemJobFlavor.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemJobFlavor? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => ResponseItemJobFlavor.CpuBasic,
                "cpu-upgrade" => ResponseItemJobFlavor.CpuUpgrade,
                "cpu-performance" => ResponseItemJobFlavor.CpuPerformance,
                "cpu-xl" => ResponseItemJobFlavor.CpuXl,
                "sprx8" => ResponseItemJobFlavor.Sprx8,
                "zero-a10g" => ResponseItemJobFlavor.ZeroA10g,
                "t4-small" => ResponseItemJobFlavor.T4Small,
                "t4-medium" => ResponseItemJobFlavor.T4Medium,
                "l4x1" => ResponseItemJobFlavor.L4x1,
                "l4x4" => ResponseItemJobFlavor.L4x4,
                "l40sx1" => ResponseItemJobFlavor.L40sx1,
                "l40sx4" => ResponseItemJobFlavor.L40sx4,
                "l40sx8" => ResponseItemJobFlavor.L40sx8,
                "a10g-small" => ResponseItemJobFlavor.A10gSmall,
                "a10g-large" => ResponseItemJobFlavor.A10gLarge,
                "a10g-largex2" => ResponseItemJobFlavor.A10gLargex2,
                "a10g-largex4" => ResponseItemJobFlavor.A10gLargex4,
                "a100-large" => ResponseItemJobFlavor.A100Large,
                "a100x4" => ResponseItemJobFlavor.A100x4,
                "a100x8" => ResponseItemJobFlavor.A100x8,
                "h200" => ResponseItemJobFlavor.H200,
                "h200x2" => ResponseItemJobFlavor.H200x2,
                "h200x4" => ResponseItemJobFlavor.H200x4,
                "h200x8" => ResponseItemJobFlavor.H200x8,
                "inf2x6" => ResponseItemJobFlavor.Inf2x6,
                _ => null,
            };
        }
    }
}