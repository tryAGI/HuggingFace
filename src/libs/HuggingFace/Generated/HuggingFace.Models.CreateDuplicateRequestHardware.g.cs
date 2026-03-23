
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDuplicateRequestHardware
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDuplicateRequestHardwareExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDuplicateRequestHardware value)
        {
            return value switch
            {
                CreateDuplicateRequestHardware.A100Large => "a100-large",
                CreateDuplicateRequestHardware.A100x4 => "a100x4",
                CreateDuplicateRequestHardware.A100x8 => "a100x8",
                CreateDuplicateRequestHardware.A10gLarge => "a10g-large",
                CreateDuplicateRequestHardware.A10gLargex2 => "a10g-largex2",
                CreateDuplicateRequestHardware.A10gLargex4 => "a10g-largex4",
                CreateDuplicateRequestHardware.A10gSmall => "a10g-small",
                CreateDuplicateRequestHardware.CpuBasic => "cpu-basic",
                CreateDuplicateRequestHardware.CpuPerformance => "cpu-performance",
                CreateDuplicateRequestHardware.CpuUpgrade => "cpu-upgrade",
                CreateDuplicateRequestHardware.CpuXl => "cpu-xl",
                CreateDuplicateRequestHardware.H200 => "h200",
                CreateDuplicateRequestHardware.H200x2 => "h200x2",
                CreateDuplicateRequestHardware.H200x4 => "h200x4",
                CreateDuplicateRequestHardware.H200x8 => "h200x8",
                CreateDuplicateRequestHardware.Inf2x6 => "inf2x6",
                CreateDuplicateRequestHardware.L40sx1 => "l40sx1",
                CreateDuplicateRequestHardware.L40sx4 => "l40sx4",
                CreateDuplicateRequestHardware.L40sx8 => "l40sx8",
                CreateDuplicateRequestHardware.L4x1 => "l4x1",
                CreateDuplicateRequestHardware.L4x4 => "l4x4",
                CreateDuplicateRequestHardware.Sprx8 => "sprx8",
                CreateDuplicateRequestHardware.T4Medium => "t4-medium",
                CreateDuplicateRequestHardware.T4Small => "t4-small",
                CreateDuplicateRequestHardware.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDuplicateRequestHardware? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateDuplicateRequestHardware.A100Large,
                "a100x4" => CreateDuplicateRequestHardware.A100x4,
                "a100x8" => CreateDuplicateRequestHardware.A100x8,
                "a10g-large" => CreateDuplicateRequestHardware.A10gLarge,
                "a10g-largex2" => CreateDuplicateRequestHardware.A10gLargex2,
                "a10g-largex4" => CreateDuplicateRequestHardware.A10gLargex4,
                "a10g-small" => CreateDuplicateRequestHardware.A10gSmall,
                "cpu-basic" => CreateDuplicateRequestHardware.CpuBasic,
                "cpu-performance" => CreateDuplicateRequestHardware.CpuPerformance,
                "cpu-upgrade" => CreateDuplicateRequestHardware.CpuUpgrade,
                "cpu-xl" => CreateDuplicateRequestHardware.CpuXl,
                "h200" => CreateDuplicateRequestHardware.H200,
                "h200x2" => CreateDuplicateRequestHardware.H200x2,
                "h200x4" => CreateDuplicateRequestHardware.H200x4,
                "h200x8" => CreateDuplicateRequestHardware.H200x8,
                "inf2x6" => CreateDuplicateRequestHardware.Inf2x6,
                "l40sx1" => CreateDuplicateRequestHardware.L40sx1,
                "l40sx4" => CreateDuplicateRequestHardware.L40sx4,
                "l40sx8" => CreateDuplicateRequestHardware.L40sx8,
                "l4x1" => CreateDuplicateRequestHardware.L4x1,
                "l4x4" => CreateDuplicateRequestHardware.L4x4,
                "sprx8" => CreateDuplicateRequestHardware.Sprx8,
                "t4-medium" => CreateDuplicateRequestHardware.T4Medium,
                "t4-small" => CreateDuplicateRequestHardware.T4Small,
                "zero-a10g" => CreateDuplicateRequestHardware.ZeroA10g,
                _ => null,
            };
        }
    }
}