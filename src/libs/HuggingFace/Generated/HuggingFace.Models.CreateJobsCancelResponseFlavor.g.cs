
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsCancelResponseFlavor
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
    public static class CreateJobsCancelResponseFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsCancelResponseFlavor value)
        {
            return value switch
            {
                CreateJobsCancelResponseFlavor.A100Large => "a100-large",
                CreateJobsCancelResponseFlavor.A100x4 => "a100x4",
                CreateJobsCancelResponseFlavor.A100x8 => "a100x8",
                CreateJobsCancelResponseFlavor.A10gLarge => "a10g-large",
                CreateJobsCancelResponseFlavor.A10gLargex2 => "a10g-largex2",
                CreateJobsCancelResponseFlavor.A10gLargex4 => "a10g-largex4",
                CreateJobsCancelResponseFlavor.A10gSmall => "a10g-small",
                CreateJobsCancelResponseFlavor.CpuBasic => "cpu-basic",
                CreateJobsCancelResponseFlavor.CpuPerformance => "cpu-performance",
                CreateJobsCancelResponseFlavor.CpuUpgrade => "cpu-upgrade",
                CreateJobsCancelResponseFlavor.CpuXl => "cpu-xl",
                CreateJobsCancelResponseFlavor.H200 => "h200",
                CreateJobsCancelResponseFlavor.H200x2 => "h200x2",
                CreateJobsCancelResponseFlavor.H200x4 => "h200x4",
                CreateJobsCancelResponseFlavor.H200x8 => "h200x8",
                CreateJobsCancelResponseFlavor.Inf2x6 => "inf2x6",
                CreateJobsCancelResponseFlavor.L40sx1 => "l40sx1",
                CreateJobsCancelResponseFlavor.L40sx4 => "l40sx4",
                CreateJobsCancelResponseFlavor.L40sx8 => "l40sx8",
                CreateJobsCancelResponseFlavor.L4x1 => "l4x1",
                CreateJobsCancelResponseFlavor.L4x4 => "l4x4",
                CreateJobsCancelResponseFlavor.Sprx8 => "sprx8",
                CreateJobsCancelResponseFlavor.T4Medium => "t4-medium",
                CreateJobsCancelResponseFlavor.T4Small => "t4-small",
                CreateJobsCancelResponseFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsCancelResponseFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateJobsCancelResponseFlavor.A100Large,
                "a100x4" => CreateJobsCancelResponseFlavor.A100x4,
                "a100x8" => CreateJobsCancelResponseFlavor.A100x8,
                "a10g-large" => CreateJobsCancelResponseFlavor.A10gLarge,
                "a10g-largex2" => CreateJobsCancelResponseFlavor.A10gLargex2,
                "a10g-largex4" => CreateJobsCancelResponseFlavor.A10gLargex4,
                "a10g-small" => CreateJobsCancelResponseFlavor.A10gSmall,
                "cpu-basic" => CreateJobsCancelResponseFlavor.CpuBasic,
                "cpu-performance" => CreateJobsCancelResponseFlavor.CpuPerformance,
                "cpu-upgrade" => CreateJobsCancelResponseFlavor.CpuUpgrade,
                "cpu-xl" => CreateJobsCancelResponseFlavor.CpuXl,
                "h200" => CreateJobsCancelResponseFlavor.H200,
                "h200x2" => CreateJobsCancelResponseFlavor.H200x2,
                "h200x4" => CreateJobsCancelResponseFlavor.H200x4,
                "h200x8" => CreateJobsCancelResponseFlavor.H200x8,
                "inf2x6" => CreateJobsCancelResponseFlavor.Inf2x6,
                "l40sx1" => CreateJobsCancelResponseFlavor.L40sx1,
                "l40sx4" => CreateJobsCancelResponseFlavor.L40sx4,
                "l40sx8" => CreateJobsCancelResponseFlavor.L40sx8,
                "l4x1" => CreateJobsCancelResponseFlavor.L4x1,
                "l4x4" => CreateJobsCancelResponseFlavor.L4x4,
                "sprx8" => CreateJobsCancelResponseFlavor.Sprx8,
                "t4-medium" => CreateJobsCancelResponseFlavor.T4Medium,
                "t4-small" => CreateJobsCancelResponseFlavor.T4Small,
                "zero-a10g" => CreateJobsCancelResponseFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}