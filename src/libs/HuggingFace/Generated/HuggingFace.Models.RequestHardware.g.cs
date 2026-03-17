
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestHardware
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
    public static class RequestHardwareExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestHardware value)
        {
            return value switch
            {
                RequestHardware.CpuBasic => "cpu-basic",
                RequestHardware.CpuUpgrade => "cpu-upgrade",
                RequestHardware.CpuPerformance => "cpu-performance",
                RequestHardware.CpuXl => "cpu-xl",
                RequestHardware.Sprx8 => "sprx8",
                RequestHardware.ZeroA10g => "zero-a10g",
                RequestHardware.T4Small => "t4-small",
                RequestHardware.T4Medium => "t4-medium",
                RequestHardware.L4x1 => "l4x1",
                RequestHardware.L4x4 => "l4x4",
                RequestHardware.L40sx1 => "l40sx1",
                RequestHardware.L40sx4 => "l40sx4",
                RequestHardware.L40sx8 => "l40sx8",
                RequestHardware.A10gSmall => "a10g-small",
                RequestHardware.A10gLarge => "a10g-large",
                RequestHardware.A10gLargex2 => "a10g-largex2",
                RequestHardware.A10gLargex4 => "a10g-largex4",
                RequestHardware.A100Large => "a100-large",
                RequestHardware.A100x4 => "a100x4",
                RequestHardware.A100x8 => "a100x8",
                RequestHardware.H200 => "h200",
                RequestHardware.H200x2 => "h200x2",
                RequestHardware.H200x4 => "h200x4",
                RequestHardware.H200x8 => "h200x8",
                RequestHardware.Inf2x6 => "inf2x6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestHardware? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => RequestHardware.CpuBasic,
                "cpu-upgrade" => RequestHardware.CpuUpgrade,
                "cpu-performance" => RequestHardware.CpuPerformance,
                "cpu-xl" => RequestHardware.CpuXl,
                "sprx8" => RequestHardware.Sprx8,
                "zero-a10g" => RequestHardware.ZeroA10g,
                "t4-small" => RequestHardware.T4Small,
                "t4-medium" => RequestHardware.T4Medium,
                "l4x1" => RequestHardware.L4x1,
                "l4x4" => RequestHardware.L4x4,
                "l40sx1" => RequestHardware.L40sx1,
                "l40sx4" => RequestHardware.L40sx4,
                "l40sx8" => RequestHardware.L40sx8,
                "a10g-small" => RequestHardware.A10gSmall,
                "a10g-large" => RequestHardware.A10gLarge,
                "a10g-largex2" => RequestHardware.A10gLargex2,
                "a10g-largex4" => RequestHardware.A10gLargex4,
                "a100-large" => RequestHardware.A100Large,
                "a100x4" => RequestHardware.A100x4,
                "a100x8" => RequestHardware.A100x8,
                "h200" => RequestHardware.H200,
                "h200x2" => RequestHardware.H200x2,
                "h200x4" => RequestHardware.H200x4,
                "h200x8" => RequestHardware.H200x8,
                "inf2x6" => RequestHardware.Inf2x6,
                _ => null,
            };
        }
    }
}