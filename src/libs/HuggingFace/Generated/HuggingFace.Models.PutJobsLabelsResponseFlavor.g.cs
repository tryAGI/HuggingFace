
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsLabelsResponseFlavor
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
    public static class PutJobsLabelsResponseFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsLabelsResponseFlavor value)
        {
            return value switch
            {
                PutJobsLabelsResponseFlavor.A100Large => "a100-large",
                PutJobsLabelsResponseFlavor.A100x4 => "a100x4",
                PutJobsLabelsResponseFlavor.A100x8 => "a100x8",
                PutJobsLabelsResponseFlavor.A10gLarge => "a10g-large",
                PutJobsLabelsResponseFlavor.A10gLargex2 => "a10g-largex2",
                PutJobsLabelsResponseFlavor.A10gLargex4 => "a10g-largex4",
                PutJobsLabelsResponseFlavor.A10gSmall => "a10g-small",
                PutJobsLabelsResponseFlavor.CpuBasic => "cpu-basic",
                PutJobsLabelsResponseFlavor.CpuPerformance => "cpu-performance",
                PutJobsLabelsResponseFlavor.CpuUpgrade => "cpu-upgrade",
                PutJobsLabelsResponseFlavor.CpuXl => "cpu-xl",
                PutJobsLabelsResponseFlavor.H200 => "h200",
                PutJobsLabelsResponseFlavor.H200x2 => "h200x2",
                PutJobsLabelsResponseFlavor.H200x4 => "h200x4",
                PutJobsLabelsResponseFlavor.H200x8 => "h200x8",
                PutJobsLabelsResponseFlavor.Inf2x6 => "inf2x6",
                PutJobsLabelsResponseFlavor.L40sx1 => "l40sx1",
                PutJobsLabelsResponseFlavor.L40sx4 => "l40sx4",
                PutJobsLabelsResponseFlavor.L40sx8 => "l40sx8",
                PutJobsLabelsResponseFlavor.L4x1 => "l4x1",
                PutJobsLabelsResponseFlavor.L4x4 => "l4x4",
                PutJobsLabelsResponseFlavor.Sprx8 => "sprx8",
                PutJobsLabelsResponseFlavor.T4Medium => "t4-medium",
                PutJobsLabelsResponseFlavor.T4Small => "t4-small",
                PutJobsLabelsResponseFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsLabelsResponseFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => PutJobsLabelsResponseFlavor.A100Large,
                "a100x4" => PutJobsLabelsResponseFlavor.A100x4,
                "a100x8" => PutJobsLabelsResponseFlavor.A100x8,
                "a10g-large" => PutJobsLabelsResponseFlavor.A10gLarge,
                "a10g-largex2" => PutJobsLabelsResponseFlavor.A10gLargex2,
                "a10g-largex4" => PutJobsLabelsResponseFlavor.A10gLargex4,
                "a10g-small" => PutJobsLabelsResponseFlavor.A10gSmall,
                "cpu-basic" => PutJobsLabelsResponseFlavor.CpuBasic,
                "cpu-performance" => PutJobsLabelsResponseFlavor.CpuPerformance,
                "cpu-upgrade" => PutJobsLabelsResponseFlavor.CpuUpgrade,
                "cpu-xl" => PutJobsLabelsResponseFlavor.CpuXl,
                "h200" => PutJobsLabelsResponseFlavor.H200,
                "h200x2" => PutJobsLabelsResponseFlavor.H200x2,
                "h200x4" => PutJobsLabelsResponseFlavor.H200x4,
                "h200x8" => PutJobsLabelsResponseFlavor.H200x8,
                "inf2x6" => PutJobsLabelsResponseFlavor.Inf2x6,
                "l40sx1" => PutJobsLabelsResponseFlavor.L40sx1,
                "l40sx4" => PutJobsLabelsResponseFlavor.L40sx4,
                "l40sx8" => PutJobsLabelsResponseFlavor.L40sx8,
                "l4x1" => PutJobsLabelsResponseFlavor.L4x1,
                "l4x4" => PutJobsLabelsResponseFlavor.L4x4,
                "sprx8" => PutJobsLabelsResponseFlavor.Sprx8,
                "t4-medium" => PutJobsLabelsResponseFlavor.T4Medium,
                "t4-small" => PutJobsLabelsResponseFlavor.T4Small,
                "zero-a10g" => PutJobsLabelsResponseFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}