
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsDuplicateResponseFlavor
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
    public static class CreateJobsDuplicateResponseFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsDuplicateResponseFlavor value)
        {
            return value switch
            {
                CreateJobsDuplicateResponseFlavor.A100Large => "a100-large",
                CreateJobsDuplicateResponseFlavor.A100x4 => "a100x4",
                CreateJobsDuplicateResponseFlavor.A100x8 => "a100x8",
                CreateJobsDuplicateResponseFlavor.A10gLarge => "a10g-large",
                CreateJobsDuplicateResponseFlavor.A10gLargex2 => "a10g-largex2",
                CreateJobsDuplicateResponseFlavor.A10gLargex4 => "a10g-largex4",
                CreateJobsDuplicateResponseFlavor.A10gSmall => "a10g-small",
                CreateJobsDuplicateResponseFlavor.CpuBasic => "cpu-basic",
                CreateJobsDuplicateResponseFlavor.CpuPerformance => "cpu-performance",
                CreateJobsDuplicateResponseFlavor.CpuUpgrade => "cpu-upgrade",
                CreateJobsDuplicateResponseFlavor.CpuXl => "cpu-xl",
                CreateJobsDuplicateResponseFlavor.H200 => "h200",
                CreateJobsDuplicateResponseFlavor.H200x2 => "h200x2",
                CreateJobsDuplicateResponseFlavor.H200x4 => "h200x4",
                CreateJobsDuplicateResponseFlavor.H200x8 => "h200x8",
                CreateJobsDuplicateResponseFlavor.Inf2x6 => "inf2x6",
                CreateJobsDuplicateResponseFlavor.L40sx1 => "l40sx1",
                CreateJobsDuplicateResponseFlavor.L40sx4 => "l40sx4",
                CreateJobsDuplicateResponseFlavor.L40sx8 => "l40sx8",
                CreateJobsDuplicateResponseFlavor.L4x1 => "l4x1",
                CreateJobsDuplicateResponseFlavor.L4x4 => "l4x4",
                CreateJobsDuplicateResponseFlavor.Sprx8 => "sprx8",
                CreateJobsDuplicateResponseFlavor.T4Medium => "t4-medium",
                CreateJobsDuplicateResponseFlavor.T4Small => "t4-small",
                CreateJobsDuplicateResponseFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsDuplicateResponseFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateJobsDuplicateResponseFlavor.A100Large,
                "a100x4" => CreateJobsDuplicateResponseFlavor.A100x4,
                "a100x8" => CreateJobsDuplicateResponseFlavor.A100x8,
                "a10g-large" => CreateJobsDuplicateResponseFlavor.A10gLarge,
                "a10g-largex2" => CreateJobsDuplicateResponseFlavor.A10gLargex2,
                "a10g-largex4" => CreateJobsDuplicateResponseFlavor.A10gLargex4,
                "a10g-small" => CreateJobsDuplicateResponseFlavor.A10gSmall,
                "cpu-basic" => CreateJobsDuplicateResponseFlavor.CpuBasic,
                "cpu-performance" => CreateJobsDuplicateResponseFlavor.CpuPerformance,
                "cpu-upgrade" => CreateJobsDuplicateResponseFlavor.CpuUpgrade,
                "cpu-xl" => CreateJobsDuplicateResponseFlavor.CpuXl,
                "h200" => CreateJobsDuplicateResponseFlavor.H200,
                "h200x2" => CreateJobsDuplicateResponseFlavor.H200x2,
                "h200x4" => CreateJobsDuplicateResponseFlavor.H200x4,
                "h200x8" => CreateJobsDuplicateResponseFlavor.H200x8,
                "inf2x6" => CreateJobsDuplicateResponseFlavor.Inf2x6,
                "l40sx1" => CreateJobsDuplicateResponseFlavor.L40sx1,
                "l40sx4" => CreateJobsDuplicateResponseFlavor.L40sx4,
                "l40sx8" => CreateJobsDuplicateResponseFlavor.L40sx8,
                "l4x1" => CreateJobsDuplicateResponseFlavor.L4x1,
                "l4x4" => CreateJobsDuplicateResponseFlavor.L4x4,
                "sprx8" => CreateJobsDuplicateResponseFlavor.Sprx8,
                "t4-medium" => CreateJobsDuplicateResponseFlavor.T4Medium,
                "t4-small" => CreateJobsDuplicateResponseFlavor.T4Small,
                "zero-a10g" => CreateJobsDuplicateResponseFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}