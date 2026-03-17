
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestJobSpecFlavor
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
    public static class RequestJobSpecFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestJobSpecFlavor value)
        {
            return value switch
            {
                RequestJobSpecFlavor.CpuBasic => "cpu-basic",
                RequestJobSpecFlavor.CpuUpgrade => "cpu-upgrade",
                RequestJobSpecFlavor.CpuPerformance => "cpu-performance",
                RequestJobSpecFlavor.CpuXl => "cpu-xl",
                RequestJobSpecFlavor.Sprx8 => "sprx8",
                RequestJobSpecFlavor.ZeroA10g => "zero-a10g",
                RequestJobSpecFlavor.T4Small => "t4-small",
                RequestJobSpecFlavor.T4Medium => "t4-medium",
                RequestJobSpecFlavor.L4x1 => "l4x1",
                RequestJobSpecFlavor.L4x4 => "l4x4",
                RequestJobSpecFlavor.L40sx1 => "l40sx1",
                RequestJobSpecFlavor.L40sx4 => "l40sx4",
                RequestJobSpecFlavor.L40sx8 => "l40sx8",
                RequestJobSpecFlavor.A10gSmall => "a10g-small",
                RequestJobSpecFlavor.A10gLarge => "a10g-large",
                RequestJobSpecFlavor.A10gLargex2 => "a10g-largex2",
                RequestJobSpecFlavor.A10gLargex4 => "a10g-largex4",
                RequestJobSpecFlavor.A100Large => "a100-large",
                RequestJobSpecFlavor.A100x4 => "a100x4",
                RequestJobSpecFlavor.A100x8 => "a100x8",
                RequestJobSpecFlavor.H200 => "h200",
                RequestJobSpecFlavor.H200x2 => "h200x2",
                RequestJobSpecFlavor.H200x4 => "h200x4",
                RequestJobSpecFlavor.H200x8 => "h200x8",
                RequestJobSpecFlavor.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestJobSpecFlavor? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => RequestJobSpecFlavor.CpuBasic,
                "cpu-upgrade" => RequestJobSpecFlavor.CpuUpgrade,
                "cpu-performance" => RequestJobSpecFlavor.CpuPerformance,
                "cpu-xl" => RequestJobSpecFlavor.CpuXl,
                "sprx8" => RequestJobSpecFlavor.Sprx8,
                "zero-a10g" => RequestJobSpecFlavor.ZeroA10g,
                "t4-small" => RequestJobSpecFlavor.T4Small,
                "t4-medium" => RequestJobSpecFlavor.T4Medium,
                "l4x1" => RequestJobSpecFlavor.L4x1,
                "l4x4" => RequestJobSpecFlavor.L4x4,
                "l40sx1" => RequestJobSpecFlavor.L40sx1,
                "l40sx4" => RequestJobSpecFlavor.L40sx4,
                "l40sx8" => RequestJobSpecFlavor.L40sx8,
                "a10g-small" => RequestJobSpecFlavor.A10gSmall,
                "a10g-large" => RequestJobSpecFlavor.A10gLarge,
                "a10g-largex2" => RequestJobSpecFlavor.A10gLargex2,
                "a10g-largex4" => RequestJobSpecFlavor.A10gLargex4,
                "a100-large" => RequestJobSpecFlavor.A100Large,
                "a100x4" => RequestJobSpecFlavor.A100x4,
                "a100x8" => RequestJobSpecFlavor.A100x8,
                "h200" => RequestJobSpecFlavor.H200,
                "h200x2" => RequestJobSpecFlavor.H200x2,
                "h200x4" => RequestJobSpecFlavor.H200x4,
                "h200x8" => RequestJobSpecFlavor.H200x8,
                "inf2x6" => RequestJobSpecFlavor.Inf2x6,
                _ => null,
            };
        }
    }
}