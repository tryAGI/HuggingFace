
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestJobFlavor
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
    public static class RequestJobFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestJobFlavor value)
        {
            return value switch
            {
                RequestJobFlavor.CpuBasic => "cpu-basic",
                RequestJobFlavor.CpuUpgrade => "cpu-upgrade",
                RequestJobFlavor.CpuPerformance => "cpu-performance",
                RequestJobFlavor.CpuXl => "cpu-xl",
                RequestJobFlavor.Sprx8 => "sprx8",
                RequestJobFlavor.ZeroA10g => "zero-a10g",
                RequestJobFlavor.T4Small => "t4-small",
                RequestJobFlavor.T4Medium => "t4-medium",
                RequestJobFlavor.L4x1 => "l4x1",
                RequestJobFlavor.L4x4 => "l4x4",
                RequestJobFlavor.L40sx1 => "l40sx1",
                RequestJobFlavor.L40sx4 => "l40sx4",
                RequestJobFlavor.L40sx8 => "l40sx8",
                RequestJobFlavor.A10gSmall => "a10g-small",
                RequestJobFlavor.A10gLarge => "a10g-large",
                RequestJobFlavor.A10gLargex2 => "a10g-largex2",
                RequestJobFlavor.A10gLargex4 => "a10g-largex4",
                RequestJobFlavor.A100Large => "a100-large",
                RequestJobFlavor.A100x4 => "a100x4",
                RequestJobFlavor.A100x8 => "a100x8",
                RequestJobFlavor.H200 => "h200",
                RequestJobFlavor.H200x2 => "h200x2",
                RequestJobFlavor.H200x4 => "h200x4",
                RequestJobFlavor.H200x8 => "h200x8",
                RequestJobFlavor.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestJobFlavor? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => RequestJobFlavor.CpuBasic,
                "cpu-upgrade" => RequestJobFlavor.CpuUpgrade,
                "cpu-performance" => RequestJobFlavor.CpuPerformance,
                "cpu-xl" => RequestJobFlavor.CpuXl,
                "sprx8" => RequestJobFlavor.Sprx8,
                "zero-a10g" => RequestJobFlavor.ZeroA10g,
                "t4-small" => RequestJobFlavor.T4Small,
                "t4-medium" => RequestJobFlavor.T4Medium,
                "l4x1" => RequestJobFlavor.L4x1,
                "l4x4" => RequestJobFlavor.L4x4,
                "l40sx1" => RequestJobFlavor.L40sx1,
                "l40sx4" => RequestJobFlavor.L40sx4,
                "l40sx8" => RequestJobFlavor.L40sx8,
                "a10g-small" => RequestJobFlavor.A10gSmall,
                "a10g-large" => RequestJobFlavor.A10gLarge,
                "a10g-largex2" => RequestJobFlavor.A10gLargex2,
                "a10g-largex4" => RequestJobFlavor.A10gLargex4,
                "a100-large" => RequestJobFlavor.A100Large,
                "a100x4" => RequestJobFlavor.A100x4,
                "a100x8" => RequestJobFlavor.A100x8,
                "h200" => RequestJobFlavor.H200,
                "h200x2" => RequestJobFlavor.H200x2,
                "h200x4" => RequestJobFlavor.H200x4,
                "h200x8" => RequestJobFlavor.H200x8,
                "inf2x6" => RequestJobFlavor.Inf2x6,
                _ => null,
            };
        }
    }
}