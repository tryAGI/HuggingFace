
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFlavor5
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
    public static class ResponseFlavor5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFlavor5 value)
        {
            return value switch
            {
                ResponseFlavor5.CpuBasic => "cpu-basic",
                ResponseFlavor5.CpuUpgrade => "cpu-upgrade",
                ResponseFlavor5.CpuPerformance => "cpu-performance",
                ResponseFlavor5.CpuXl => "cpu-xl",
                ResponseFlavor5.Sprx8 => "sprx8",
                ResponseFlavor5.ZeroA10g => "zero-a10g",
                ResponseFlavor5.T4Small => "t4-small",
                ResponseFlavor5.T4Medium => "t4-medium",
                ResponseFlavor5.L4x1 => "l4x1",
                ResponseFlavor5.L4x4 => "l4x4",
                ResponseFlavor5.L40sx1 => "l40sx1",
                ResponseFlavor5.L40sx4 => "l40sx4",
                ResponseFlavor5.L40sx8 => "l40sx8",
                ResponseFlavor5.A10gSmall => "a10g-small",
                ResponseFlavor5.A10gLarge => "a10g-large",
                ResponseFlavor5.A10gLargex2 => "a10g-largex2",
                ResponseFlavor5.A10gLargex4 => "a10g-largex4",
                ResponseFlavor5.A100Large => "a100-large",
                ResponseFlavor5.A100x4 => "a100x4",
                ResponseFlavor5.A100x8 => "a100x8",
                ResponseFlavor5.H200 => "h200",
                ResponseFlavor5.H200x2 => "h200x2",
                ResponseFlavor5.H200x4 => "h200x4",
                ResponseFlavor5.H200x8 => "h200x8",
                ResponseFlavor5.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFlavor5? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => ResponseFlavor5.CpuBasic,
                "cpu-upgrade" => ResponseFlavor5.CpuUpgrade,
                "cpu-performance" => ResponseFlavor5.CpuPerformance,
                "cpu-xl" => ResponseFlavor5.CpuXl,
                "sprx8" => ResponseFlavor5.Sprx8,
                "zero-a10g" => ResponseFlavor5.ZeroA10g,
                "t4-small" => ResponseFlavor5.T4Small,
                "t4-medium" => ResponseFlavor5.T4Medium,
                "l4x1" => ResponseFlavor5.L4x1,
                "l4x4" => ResponseFlavor5.L4x4,
                "l40sx1" => ResponseFlavor5.L40sx1,
                "l40sx4" => ResponseFlavor5.L40sx4,
                "l40sx8" => ResponseFlavor5.L40sx8,
                "a10g-small" => ResponseFlavor5.A10gSmall,
                "a10g-large" => ResponseFlavor5.A10gLarge,
                "a10g-largex2" => ResponseFlavor5.A10gLargex2,
                "a10g-largex4" => ResponseFlavor5.A10gLargex4,
                "a100-large" => ResponseFlavor5.A100Large,
                "a100x4" => ResponseFlavor5.A100x4,
                "a100x8" => ResponseFlavor5.A100x8,
                "h200" => ResponseFlavor5.H200,
                "h200x2" => ResponseFlavor5.H200x2,
                "h200x4" => ResponseFlavor5.H200x4,
                "h200x8" => ResponseFlavor5.H200x8,
                "inf2x6" => ResponseFlavor5.Inf2x6,
                _ => null,
            };
        }
    }
}