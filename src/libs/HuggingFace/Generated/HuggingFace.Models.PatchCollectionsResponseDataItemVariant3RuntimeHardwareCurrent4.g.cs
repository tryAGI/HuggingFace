
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4
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
    public static class PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A100Large => "a100-large",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A100x4 => "a100x4",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A100x8 => "a100x8",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A10gLarge => "a10g-large",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A10gLargex2 => "a10g-largex2",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A10gLargex4 => "a10g-largex4",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A10gSmall => "a10g-small",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.CpuBasic => "cpu-basic",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.CpuPerformance => "cpu-performance",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.CpuUpgrade => "cpu-upgrade",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.CpuXl => "cpu-xl",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.H200 => "h200",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.H200x2 => "h200x2",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.H200x4 => "h200x4",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.H200x8 => "h200x8",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.Inf2x6 => "inf2x6",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.L40sx1 => "l40sx1",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.L40sx4 => "l40sx4",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.L40sx8 => "l40sx8",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.L4x1 => "l4x1",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.L4x4 => "l4x4",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.Sprx8 => "sprx8",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.T4Medium => "t4-medium",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.T4Small => "t4-small",
                PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A100Large,
                "a100x4" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A100x4,
                "a100x8" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A100x8,
                "a10g-large" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A10gLarge,
                "a10g-largex2" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A10gLargex2,
                "a10g-largex4" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A10gLargex4,
                "a10g-small" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.A10gSmall,
                "cpu-basic" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.CpuBasic,
                "cpu-performance" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.CpuPerformance,
                "cpu-upgrade" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.CpuUpgrade,
                "cpu-xl" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.CpuXl,
                "h200" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.H200,
                "h200x2" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.H200x2,
                "h200x4" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.H200x4,
                "h200x8" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.H200x8,
                "inf2x6" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.Inf2x6,
                "l40sx1" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.L40sx1,
                "l40sx4" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.L40sx4,
                "l40sx8" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.L40sx8,
                "l4x1" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.L4x1,
                "l4x4" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.L4x4,
                "sprx8" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.Sprx8,
                "t4-medium" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.T4Medium,
                "t4-small" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.T4Small,
                "zero-a10g" => PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent4.ZeroA10g,
                _ => null,
            };
        }
    }
}