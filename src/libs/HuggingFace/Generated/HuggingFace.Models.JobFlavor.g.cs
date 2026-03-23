
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobFlavor
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
    public static class JobFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobFlavor value)
        {
            return value switch
            {
                JobFlavor.A100Large => "a100-large",
                JobFlavor.A100x4 => "a100x4",
                JobFlavor.A100x8 => "a100x8",
                JobFlavor.A10gLarge => "a10g-large",
                JobFlavor.A10gLargex2 => "a10g-largex2",
                JobFlavor.A10gLargex4 => "a10g-largex4",
                JobFlavor.A10gSmall => "a10g-small",
                JobFlavor.CpuBasic => "cpu-basic",
                JobFlavor.CpuPerformance => "cpu-performance",
                JobFlavor.CpuUpgrade => "cpu-upgrade",
                JobFlavor.CpuXl => "cpu-xl",
                JobFlavor.H200 => "h200",
                JobFlavor.H200x2 => "h200x2",
                JobFlavor.H200x4 => "h200x4",
                JobFlavor.H200x8 => "h200x8",
                JobFlavor.Inf2x6 => "inf2x6",
                JobFlavor.L40sx1 => "l40sx1",
                JobFlavor.L40sx4 => "l40sx4",
                JobFlavor.L40sx8 => "l40sx8",
                JobFlavor.L4x1 => "l4x1",
                JobFlavor.L4x4 => "l4x4",
                JobFlavor.Sprx8 => "sprx8",
                JobFlavor.T4Medium => "t4-medium",
                JobFlavor.T4Small => "t4-small",
                JobFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => JobFlavor.A100Large,
                "a100x4" => JobFlavor.A100x4,
                "a100x8" => JobFlavor.A100x8,
                "a10g-large" => JobFlavor.A10gLarge,
                "a10g-largex2" => JobFlavor.A10gLargex2,
                "a10g-largex4" => JobFlavor.A10gLargex4,
                "a10g-small" => JobFlavor.A10gSmall,
                "cpu-basic" => JobFlavor.CpuBasic,
                "cpu-performance" => JobFlavor.CpuPerformance,
                "cpu-upgrade" => JobFlavor.CpuUpgrade,
                "cpu-xl" => JobFlavor.CpuXl,
                "h200" => JobFlavor.H200,
                "h200x2" => JobFlavor.H200x2,
                "h200x4" => JobFlavor.H200x4,
                "h200x8" => JobFlavor.H200x8,
                "inf2x6" => JobFlavor.Inf2x6,
                "l40sx1" => JobFlavor.L40sx1,
                "l40sx4" => JobFlavor.L40sx4,
                "l40sx8" => JobFlavor.L40sx8,
                "l4x1" => JobFlavor.L4x1,
                "l4x4" => JobFlavor.L4x4,
                "sprx8" => JobFlavor.Sprx8,
                "t4-medium" => JobFlavor.T4Medium,
                "t4-small" => JobFlavor.T4Small,
                "zero-a10g" => JobFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}