
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// The hardware flavor of the space. If you select 'zero-a10g' or 'zerogpu', the SDK must be Gradio.
    /// </summary>
    public enum RequestVariant4Hardware
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
        /// <summary>
        /// 
        /// </summary>
        Zerogpu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestVariant4HardwareExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant4Hardware value)
        {
            return value switch
            {
                RequestVariant4Hardware.CpuBasic => "cpu-basic",
                RequestVariant4Hardware.CpuUpgrade => "cpu-upgrade",
                RequestVariant4Hardware.CpuPerformance => "cpu-performance",
                RequestVariant4Hardware.CpuXl => "cpu-xl",
                RequestVariant4Hardware.Sprx8 => "sprx8",
                RequestVariant4Hardware.ZeroA10g => "zero-a10g",
                RequestVariant4Hardware.T4Small => "t4-small",
                RequestVariant4Hardware.T4Medium => "t4-medium",
                RequestVariant4Hardware.L4x1 => "l4x1",
                RequestVariant4Hardware.L4x4 => "l4x4",
                RequestVariant4Hardware.L40sx1 => "l40sx1",
                RequestVariant4Hardware.L40sx4 => "l40sx4",
                RequestVariant4Hardware.L40sx8 => "l40sx8",
                RequestVariant4Hardware.A10gSmall => "a10g-small",
                RequestVariant4Hardware.A10gLarge => "a10g-large",
                RequestVariant4Hardware.A10gLargex2 => "a10g-largex2",
                RequestVariant4Hardware.A10gLargex4 => "a10g-largex4",
                RequestVariant4Hardware.A100Large => "a100-large",
                RequestVariant4Hardware.A100x4 => "a100x4",
                RequestVariant4Hardware.A100x8 => "a100x8",
                RequestVariant4Hardware.H200 => "h200",
                RequestVariant4Hardware.H200x2 => "h200x2",
                RequestVariant4Hardware.H200x4 => "h200x4",
                RequestVariant4Hardware.H200x8 => "h200x8",
                RequestVariant4Hardware.Inf2x6 => "inf2x6",
                RequestVariant4Hardware.Zerogpu => "zerogpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant4Hardware? ToEnum(string value)
        {
            return value switch
            {
                "cpu-basic" => RequestVariant4Hardware.CpuBasic,
                "cpu-upgrade" => RequestVariant4Hardware.CpuUpgrade,
                "cpu-performance" => RequestVariant4Hardware.CpuPerformance,
                "cpu-xl" => RequestVariant4Hardware.CpuXl,
                "sprx8" => RequestVariant4Hardware.Sprx8,
                "zero-a10g" => RequestVariant4Hardware.ZeroA10g,
                "t4-small" => RequestVariant4Hardware.T4Small,
                "t4-medium" => RequestVariant4Hardware.T4Medium,
                "l4x1" => RequestVariant4Hardware.L4x1,
                "l4x4" => RequestVariant4Hardware.L4x4,
                "l40sx1" => RequestVariant4Hardware.L40sx1,
                "l40sx4" => RequestVariant4Hardware.L40sx4,
                "l40sx8" => RequestVariant4Hardware.L40sx8,
                "a10g-small" => RequestVariant4Hardware.A10gSmall,
                "a10g-large" => RequestVariant4Hardware.A10gLarge,
                "a10g-largex2" => RequestVariant4Hardware.A10gLargex2,
                "a10g-largex4" => RequestVariant4Hardware.A10gLargex4,
                "a100-large" => RequestVariant4Hardware.A100Large,
                "a100x4" => RequestVariant4Hardware.A100x4,
                "a100x8" => RequestVariant4Hardware.A100x8,
                "h200" => RequestVariant4Hardware.H200,
                "h200x2" => RequestVariant4Hardware.H200x2,
                "h200x4" => RequestVariant4Hardware.H200x4,
                "h200x8" => RequestVariant4Hardware.H200x8,
                "inf2x6" => RequestVariant4Hardware.Inf2x6,
                "zerogpu" => RequestVariant4Hardware.Zerogpu,
                _ => null,
            };
        }
    }
}