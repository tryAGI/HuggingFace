
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsExposeResponseFlavor
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
    public static class PutJobsExposeResponseFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsExposeResponseFlavor value)
        {
            return value switch
            {
                PutJobsExposeResponseFlavor.A100Large => "a100-large",
                PutJobsExposeResponseFlavor.A100x4 => "a100x4",
                PutJobsExposeResponseFlavor.A100x8 => "a100x8",
                PutJobsExposeResponseFlavor.A10gLarge => "a10g-large",
                PutJobsExposeResponseFlavor.A10gLargex2 => "a10g-largex2",
                PutJobsExposeResponseFlavor.A10gLargex4 => "a10g-largex4",
                PutJobsExposeResponseFlavor.A10gSmall => "a10g-small",
                PutJobsExposeResponseFlavor.CpuBasic => "cpu-basic",
                PutJobsExposeResponseFlavor.CpuPerformance => "cpu-performance",
                PutJobsExposeResponseFlavor.CpuUpgrade => "cpu-upgrade",
                PutJobsExposeResponseFlavor.CpuXl => "cpu-xl",
                PutJobsExposeResponseFlavor.H200 => "h200",
                PutJobsExposeResponseFlavor.H200x2 => "h200x2",
                PutJobsExposeResponseFlavor.H200x4 => "h200x4",
                PutJobsExposeResponseFlavor.H200x8 => "h200x8",
                PutJobsExposeResponseFlavor.Inf2x6 => "inf2x6",
                PutJobsExposeResponseFlavor.L40sx1 => "l40sx1",
                PutJobsExposeResponseFlavor.L40sx4 => "l40sx4",
                PutJobsExposeResponseFlavor.L40sx8 => "l40sx8",
                PutJobsExposeResponseFlavor.L4x1 => "l4x1",
                PutJobsExposeResponseFlavor.L4x4 => "l4x4",
                PutJobsExposeResponseFlavor.RtxPro6000 => "rtx-pro-6000",
                PutJobsExposeResponseFlavor.RtxPro6000x2 => "rtx-pro-6000x2",
                PutJobsExposeResponseFlavor.RtxPro6000x4 => "rtx-pro-6000x4",
                PutJobsExposeResponseFlavor.RtxPro6000x8 => "rtx-pro-6000x8",
                PutJobsExposeResponseFlavor.Sprx8 => "sprx8",
                PutJobsExposeResponseFlavor.T4Medium => "t4-medium",
                PutJobsExposeResponseFlavor.T4Small => "t4-small",
                PutJobsExposeResponseFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsExposeResponseFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => PutJobsExposeResponseFlavor.A100Large,
                "a100x4" => PutJobsExposeResponseFlavor.A100x4,
                "a100x8" => PutJobsExposeResponseFlavor.A100x8,
                "a10g-large" => PutJobsExposeResponseFlavor.A10gLarge,
                "a10g-largex2" => PutJobsExposeResponseFlavor.A10gLargex2,
                "a10g-largex4" => PutJobsExposeResponseFlavor.A10gLargex4,
                "a10g-small" => PutJobsExposeResponseFlavor.A10gSmall,
                "cpu-basic" => PutJobsExposeResponseFlavor.CpuBasic,
                "cpu-performance" => PutJobsExposeResponseFlavor.CpuPerformance,
                "cpu-upgrade" => PutJobsExposeResponseFlavor.CpuUpgrade,
                "cpu-xl" => PutJobsExposeResponseFlavor.CpuXl,
                "h200" => PutJobsExposeResponseFlavor.H200,
                "h200x2" => PutJobsExposeResponseFlavor.H200x2,
                "h200x4" => PutJobsExposeResponseFlavor.H200x4,
                "h200x8" => PutJobsExposeResponseFlavor.H200x8,
                "inf2x6" => PutJobsExposeResponseFlavor.Inf2x6,
                "l40sx1" => PutJobsExposeResponseFlavor.L40sx1,
                "l40sx4" => PutJobsExposeResponseFlavor.L40sx4,
                "l40sx8" => PutJobsExposeResponseFlavor.L40sx8,
                "l4x1" => PutJobsExposeResponseFlavor.L4x1,
                "l4x4" => PutJobsExposeResponseFlavor.L4x4,
                "rtx-pro-6000" => PutJobsExposeResponseFlavor.RtxPro6000,
                "rtx-pro-6000x2" => PutJobsExposeResponseFlavor.RtxPro6000x2,
                "rtx-pro-6000x4" => PutJobsExposeResponseFlavor.RtxPro6000x4,
                "rtx-pro-6000x8" => PutJobsExposeResponseFlavor.RtxPro6000x8,
                "sprx8" => PutJobsExposeResponseFlavor.Sprx8,
                "t4-medium" => PutJobsExposeResponseFlavor.T4Medium,
                "t4-small" => PutJobsExposeResponseFlavor.T4Small,
                "zero-a10g" => PutJobsExposeResponseFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}