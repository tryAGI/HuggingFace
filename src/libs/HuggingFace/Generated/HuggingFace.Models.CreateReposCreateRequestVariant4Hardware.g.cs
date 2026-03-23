
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// The hardware flavor of the space. If you select 'zero-a10g' or 'zerogpu', the SDK must be Gradio.
    /// </summary>
    public enum CreateReposCreateRequestVariant4Hardware
    {
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
        A10gSmall,
        /// <summary>
        /// 
        /// </summary>
        CpuBasic,
        /// <summary>
        /// 
        /// </summary>
        CpuPerformance,
        /// <summary>
        /// 
        /// </summary>
        CpuUpgrade,
        /// <summary>
        /// 
        /// </summary>
        CpuXl,
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
        L4x1,
        /// <summary>
        /// 
        /// </summary>
        L4x4,
        /// <summary>
        /// 
        /// </summary>
        Sprx8,
        /// <summary>
        /// 
        /// </summary>
        T4Medium,
        /// <summary>
        /// 
        /// </summary>
        T4Small,
        /// <summary>
        /// 
        /// </summary>
        ZeroA10g,
        /// <summary>
        /// 
        /// </summary>
        Zerogpu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateReposCreateRequestVariant4HardwareExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant4Hardware value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant4Hardware.A100Large => "a100-large",
                CreateReposCreateRequestVariant4Hardware.A100x4 => "a100x4",
                CreateReposCreateRequestVariant4Hardware.A100x8 => "a100x8",
                CreateReposCreateRequestVariant4Hardware.A10gLarge => "a10g-large",
                CreateReposCreateRequestVariant4Hardware.A10gLargex2 => "a10g-largex2",
                CreateReposCreateRequestVariant4Hardware.A10gLargex4 => "a10g-largex4",
                CreateReposCreateRequestVariant4Hardware.A10gSmall => "a10g-small",
                CreateReposCreateRequestVariant4Hardware.CpuBasic => "cpu-basic",
                CreateReposCreateRequestVariant4Hardware.CpuPerformance => "cpu-performance",
                CreateReposCreateRequestVariant4Hardware.CpuUpgrade => "cpu-upgrade",
                CreateReposCreateRequestVariant4Hardware.CpuXl => "cpu-xl",
                CreateReposCreateRequestVariant4Hardware.H200 => "h200",
                CreateReposCreateRequestVariant4Hardware.H200x2 => "h200x2",
                CreateReposCreateRequestVariant4Hardware.H200x4 => "h200x4",
                CreateReposCreateRequestVariant4Hardware.H200x8 => "h200x8",
                CreateReposCreateRequestVariant4Hardware.Inf2x6 => "inf2x6",
                CreateReposCreateRequestVariant4Hardware.L40sx1 => "l40sx1",
                CreateReposCreateRequestVariant4Hardware.L40sx4 => "l40sx4",
                CreateReposCreateRequestVariant4Hardware.L40sx8 => "l40sx8",
                CreateReposCreateRequestVariant4Hardware.L4x1 => "l4x1",
                CreateReposCreateRequestVariant4Hardware.L4x4 => "l4x4",
                CreateReposCreateRequestVariant4Hardware.Sprx8 => "sprx8",
                CreateReposCreateRequestVariant4Hardware.T4Medium => "t4-medium",
                CreateReposCreateRequestVariant4Hardware.T4Small => "t4-small",
                CreateReposCreateRequestVariant4Hardware.ZeroA10g => "zero-a10g",
                CreateReposCreateRequestVariant4Hardware.Zerogpu => "zerogpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant4Hardware? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateReposCreateRequestVariant4Hardware.A100Large,
                "a100x4" => CreateReposCreateRequestVariant4Hardware.A100x4,
                "a100x8" => CreateReposCreateRequestVariant4Hardware.A100x8,
                "a10g-large" => CreateReposCreateRequestVariant4Hardware.A10gLarge,
                "a10g-largex2" => CreateReposCreateRequestVariant4Hardware.A10gLargex2,
                "a10g-largex4" => CreateReposCreateRequestVariant4Hardware.A10gLargex4,
                "a10g-small" => CreateReposCreateRequestVariant4Hardware.A10gSmall,
                "cpu-basic" => CreateReposCreateRequestVariant4Hardware.CpuBasic,
                "cpu-performance" => CreateReposCreateRequestVariant4Hardware.CpuPerformance,
                "cpu-upgrade" => CreateReposCreateRequestVariant4Hardware.CpuUpgrade,
                "cpu-xl" => CreateReposCreateRequestVariant4Hardware.CpuXl,
                "h200" => CreateReposCreateRequestVariant4Hardware.H200,
                "h200x2" => CreateReposCreateRequestVariant4Hardware.H200x2,
                "h200x4" => CreateReposCreateRequestVariant4Hardware.H200x4,
                "h200x8" => CreateReposCreateRequestVariant4Hardware.H200x8,
                "inf2x6" => CreateReposCreateRequestVariant4Hardware.Inf2x6,
                "l40sx1" => CreateReposCreateRequestVariant4Hardware.L40sx1,
                "l40sx4" => CreateReposCreateRequestVariant4Hardware.L40sx4,
                "l40sx8" => CreateReposCreateRequestVariant4Hardware.L40sx8,
                "l4x1" => CreateReposCreateRequestVariant4Hardware.L4x1,
                "l4x4" => CreateReposCreateRequestVariant4Hardware.L4x4,
                "sprx8" => CreateReposCreateRequestVariant4Hardware.Sprx8,
                "t4-medium" => CreateReposCreateRequestVariant4Hardware.T4Medium,
                "t4-small" => CreateReposCreateRequestVariant4Hardware.T4Small,
                "zero-a10g" => CreateReposCreateRequestVariant4Hardware.ZeroA10g,
                "zerogpu" => CreateReposCreateRequestVariant4Hardware.Zerogpu,
                _ => null,
            };
        }
    }
}