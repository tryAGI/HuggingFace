
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestFlavor
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
    public static class RequestFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestFlavor value)
        {
            return value switch
            {
                RequestFlavor.CpuBasic => "cpu-basic",
                RequestFlavor.CpuUpgrade => "cpu-upgrade",
                RequestFlavor.CpuPerformance => "cpu-performance",
                RequestFlavor.CpuXl => "cpu-xl",
                RequestFlavor.Sprx8 => "sprx8",
                RequestFlavor.ZeroA10g => "zero-a10g",
                RequestFlavor.T4Small => "t4-small",
                RequestFlavor.T4Medium => "t4-medium",
                RequestFlavor.L4x1 => "l4x1",
                RequestFlavor.L4x4 => "l4x4",
                RequestFlavor.L40sx1 => "l40sx1",
                RequestFlavor.L40sx4 => "l40sx4",
                RequestFlavor.L40sx8 => "l40sx8",
                RequestFlavor.A10gSmall => "a10g-small",
                RequestFlavor.A10gLarge => "a10g-large",
                RequestFlavor.A10gLargex2 => "a10g-largex2",
                RequestFlavor.A10gLargex4 => "a10g-largex4",
                RequestFlavor.A100Large => "a100-large",
                RequestFlavor.A100x4 => "a100x4",
                RequestFlavor.A100x8 => "a100x8",
                RequestFlavor.H200 => "h200",
                RequestFlavor.H200x2 => "h200x2",
                RequestFlavor.H200x4 => "h200x4",
                RequestFlavor.H200x8 => "h200x8",
                RequestFlavor.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestFlavor? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => RequestFlavor.CpuBasic,
                "cpu-upgrade" => RequestFlavor.CpuUpgrade,
                "cpu-performance" => RequestFlavor.CpuPerformance,
                "cpu-xl" => RequestFlavor.CpuXl,
                "sprx8" => RequestFlavor.Sprx8,
                "zero-a10g" => RequestFlavor.ZeroA10g,
                "t4-small" => RequestFlavor.T4Small,
                "t4-medium" => RequestFlavor.T4Medium,
                "l4x1" => RequestFlavor.L4x1,
                "l4x4" => RequestFlavor.L4x4,
                "l40sx1" => RequestFlavor.L40sx1,
                "l40sx4" => RequestFlavor.L40sx4,
                "l40sx8" => RequestFlavor.L40sx8,
                "a10g-small" => RequestFlavor.A10gSmall,
                "a10g-large" => RequestFlavor.A10gLarge,
                "a10g-largex2" => RequestFlavor.A10gLargex2,
                "a10g-largex4" => RequestFlavor.A10gLargex4,
                "a100-large" => RequestFlavor.A100Large,
                "a100x4" => RequestFlavor.A100x4,
                "a100x8" => RequestFlavor.A100x8,
                "h200" => RequestFlavor.H200,
                "h200x2" => RequestFlavor.H200x2,
                "h200x4" => RequestFlavor.H200x4,
                "h200x8" => RequestFlavor.H200x8,
                "inf2x6" => RequestFlavor.Inf2x6,
                _ => null,
            };
        }
    }
}