
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSpacesHardwareRequestFlavor
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
        RtxPro6000,
        /// <summary>
        ///
        /// </summary>
        RtxPro6000x2,
        /// <summary>
        ///
        /// </summary>
        RtxPro6000x4,
        /// <summary>
        ///
        /// </summary>
        RtxPro6000x8,
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
    public static class CreateSpacesHardwareRequestFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesHardwareRequestFlavor value)
        {
            return value switch
            {
                CreateSpacesHardwareRequestFlavor.A100Large => "a100-large",
                CreateSpacesHardwareRequestFlavor.A100x4 => "a100x4",
                CreateSpacesHardwareRequestFlavor.A100x8 => "a100x8",
                CreateSpacesHardwareRequestFlavor.A10gLarge => "a10g-large",
                CreateSpacesHardwareRequestFlavor.A10gLargex2 => "a10g-largex2",
                CreateSpacesHardwareRequestFlavor.A10gLargex4 => "a10g-largex4",
                CreateSpacesHardwareRequestFlavor.A10gSmall => "a10g-small",
                CreateSpacesHardwareRequestFlavor.CpuBasic => "cpu-basic",
                CreateSpacesHardwareRequestFlavor.CpuPerformance => "cpu-performance",
                CreateSpacesHardwareRequestFlavor.CpuUpgrade => "cpu-upgrade",
                CreateSpacesHardwareRequestFlavor.CpuXl => "cpu-xl",
                CreateSpacesHardwareRequestFlavor.H200 => "h200",
                CreateSpacesHardwareRequestFlavor.H200x2 => "h200x2",
                CreateSpacesHardwareRequestFlavor.H200x4 => "h200x4",
                CreateSpacesHardwareRequestFlavor.H200x8 => "h200x8",
                CreateSpacesHardwareRequestFlavor.Inf2x6 => "inf2x6",
                CreateSpacesHardwareRequestFlavor.L40sx1 => "l40sx1",
                CreateSpacesHardwareRequestFlavor.L40sx4 => "l40sx4",
                CreateSpacesHardwareRequestFlavor.L40sx8 => "l40sx8",
                CreateSpacesHardwareRequestFlavor.L4x1 => "l4x1",
                CreateSpacesHardwareRequestFlavor.L4x4 => "l4x4",
                CreateSpacesHardwareRequestFlavor.RtxPro6000 => "rtx-pro-6000",
                CreateSpacesHardwareRequestFlavor.RtxPro6000x2 => "rtx-pro-6000x2",
                CreateSpacesHardwareRequestFlavor.RtxPro6000x4 => "rtx-pro-6000x4",
                CreateSpacesHardwareRequestFlavor.RtxPro6000x8 => "rtx-pro-6000x8",
                CreateSpacesHardwareRequestFlavor.Sprx8 => "sprx8",
                CreateSpacesHardwareRequestFlavor.T4Medium => "t4-medium",
                CreateSpacesHardwareRequestFlavor.T4Small => "t4-small",
                CreateSpacesHardwareRequestFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesHardwareRequestFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateSpacesHardwareRequestFlavor.A100Large,
                "a100x4" => CreateSpacesHardwareRequestFlavor.A100x4,
                "a100x8" => CreateSpacesHardwareRequestFlavor.A100x8,
                "a10g-large" => CreateSpacesHardwareRequestFlavor.A10gLarge,
                "a10g-largex2" => CreateSpacesHardwareRequestFlavor.A10gLargex2,
                "a10g-largex4" => CreateSpacesHardwareRequestFlavor.A10gLargex4,
                "a10g-small" => CreateSpacesHardwareRequestFlavor.A10gSmall,
                "cpu-basic" => CreateSpacesHardwareRequestFlavor.CpuBasic,
                "cpu-performance" => CreateSpacesHardwareRequestFlavor.CpuPerformance,
                "cpu-upgrade" => CreateSpacesHardwareRequestFlavor.CpuUpgrade,
                "cpu-xl" => CreateSpacesHardwareRequestFlavor.CpuXl,
                "h200" => CreateSpacesHardwareRequestFlavor.H200,
                "h200x2" => CreateSpacesHardwareRequestFlavor.H200x2,
                "h200x4" => CreateSpacesHardwareRequestFlavor.H200x4,
                "h200x8" => CreateSpacesHardwareRequestFlavor.H200x8,
                "inf2x6" => CreateSpacesHardwareRequestFlavor.Inf2x6,
                "l40sx1" => CreateSpacesHardwareRequestFlavor.L40sx1,
                "l40sx4" => CreateSpacesHardwareRequestFlavor.L40sx4,
                "l40sx8" => CreateSpacesHardwareRequestFlavor.L40sx8,
                "l4x1" => CreateSpacesHardwareRequestFlavor.L4x1,
                "l4x4" => CreateSpacesHardwareRequestFlavor.L4x4,
                "rtx-pro-6000" => CreateSpacesHardwareRequestFlavor.RtxPro6000,
                "rtx-pro-6000x2" => CreateSpacesHardwareRequestFlavor.RtxPro6000x2,
                "rtx-pro-6000x4" => CreateSpacesHardwareRequestFlavor.RtxPro6000x4,
                "rtx-pro-6000x8" => CreateSpacesHardwareRequestFlavor.RtxPro6000x8,
                "sprx8" => CreateSpacesHardwareRequestFlavor.Sprx8,
                "t4-medium" => CreateSpacesHardwareRequestFlavor.T4Medium,
                "t4-small" => CreateSpacesHardwareRequestFlavor.T4Small,
                "zero-a10g" => CreateSpacesHardwareRequestFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}