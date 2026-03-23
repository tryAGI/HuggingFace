
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2
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
    public static class CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A100Large => "a100-large",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A100x4 => "a100x4",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A100x8 => "a100x8",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A10gLarge => "a10g-large",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A10gLargex2 => "a10g-largex2",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A10gLargex4 => "a10g-largex4",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A10gSmall => "a10g-small",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.CpuBasic => "cpu-basic",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.CpuPerformance => "cpu-performance",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.CpuUpgrade => "cpu-upgrade",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.CpuXl => "cpu-xl",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.H200 => "h200",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.H200x2 => "h200x2",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.H200x4 => "h200x4",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.H200x8 => "h200x8",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.Inf2x6 => "inf2x6",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.L40sx1 => "l40sx1",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.L40sx4 => "l40sx4",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.L40sx8 => "l40sx8",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.L4x1 => "l4x1",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.L4x4 => "l4x4",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.Sprx8 => "sprx8",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.T4Medium => "t4-medium",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.T4Small => "t4-small",
                CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A100Large,
                "a100x4" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A100x4,
                "a100x8" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A100x8,
                "a10g-large" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A10gLarge,
                "a10g-largex2" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A10gLargex2,
                "a10g-largex4" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A10gLargex4,
                "a10g-small" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.A10gSmall,
                "cpu-basic" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.CpuBasic,
                "cpu-performance" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.CpuPerformance,
                "cpu-upgrade" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.CpuUpgrade,
                "cpu-xl" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.CpuXl,
                "h200" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.H200,
                "h200x2" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.H200x2,
                "h200x4" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.H200x4,
                "h200x8" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.H200x8,
                "inf2x6" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.Inf2x6,
                "l40sx1" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.L40sx1,
                "l40sx4" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.L40sx4,
                "l40sx8" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.L40sx8,
                "l4x1" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.L4x1,
                "l4x4" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.L4x4,
                "sprx8" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.Sprx8,
                "t4-medium" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.T4Medium,
                "t4-small" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.T4Small,
                "zero-a10g" => CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2.ZeroA10g,
                _ => null,
            };
        }
    }
}