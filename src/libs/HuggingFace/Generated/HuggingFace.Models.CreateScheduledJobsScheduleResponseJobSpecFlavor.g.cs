
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsScheduleResponseJobSpecFlavor
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
    public static class CreateScheduledJobsScheduleResponseJobSpecFlavorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsScheduleResponseJobSpecFlavor value)
        {
            return value switch
            {
                CreateScheduledJobsScheduleResponseJobSpecFlavor.A100Large => "a100-large",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.A100x4 => "a100x4",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.A100x8 => "a100x8",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.A10gLarge => "a10g-large",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.A10gLargex2 => "a10g-largex2",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.A10gLargex4 => "a10g-largex4",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.A10gSmall => "a10g-small",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.CpuBasic => "cpu-basic",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.CpuPerformance => "cpu-performance",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.CpuUpgrade => "cpu-upgrade",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.CpuXl => "cpu-xl",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.H200 => "h200",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.H200x2 => "h200x2",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.H200x4 => "h200x4",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.H200x8 => "h200x8",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.Inf2x6 => "inf2x6",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.L40sx1 => "l40sx1",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.L40sx4 => "l40sx4",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.L40sx8 => "l40sx8",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.L4x1 => "l4x1",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.L4x4 => "l4x4",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.Sprx8 => "sprx8",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.T4Medium => "t4-medium",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.T4Small => "t4-small",
                CreateScheduledJobsScheduleResponseJobSpecFlavor.ZeroA10g => "zero-a10g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsScheduleResponseJobSpecFlavor? ToEnum(string value)
        {
            return value switch
            {
                "a100-large" => CreateScheduledJobsScheduleResponseJobSpecFlavor.A100Large,
                "a100x4" => CreateScheduledJobsScheduleResponseJobSpecFlavor.A100x4,
                "a100x8" => CreateScheduledJobsScheduleResponseJobSpecFlavor.A100x8,
                "a10g-large" => CreateScheduledJobsScheduleResponseJobSpecFlavor.A10gLarge,
                "a10g-largex2" => CreateScheduledJobsScheduleResponseJobSpecFlavor.A10gLargex2,
                "a10g-largex4" => CreateScheduledJobsScheduleResponseJobSpecFlavor.A10gLargex4,
                "a10g-small" => CreateScheduledJobsScheduleResponseJobSpecFlavor.A10gSmall,
                "cpu-basic" => CreateScheduledJobsScheduleResponseJobSpecFlavor.CpuBasic,
                "cpu-performance" => CreateScheduledJobsScheduleResponseJobSpecFlavor.CpuPerformance,
                "cpu-upgrade" => CreateScheduledJobsScheduleResponseJobSpecFlavor.CpuUpgrade,
                "cpu-xl" => CreateScheduledJobsScheduleResponseJobSpecFlavor.CpuXl,
                "h200" => CreateScheduledJobsScheduleResponseJobSpecFlavor.H200,
                "h200x2" => CreateScheduledJobsScheduleResponseJobSpecFlavor.H200x2,
                "h200x4" => CreateScheduledJobsScheduleResponseJobSpecFlavor.H200x4,
                "h200x8" => CreateScheduledJobsScheduleResponseJobSpecFlavor.H200x8,
                "inf2x6" => CreateScheduledJobsScheduleResponseJobSpecFlavor.Inf2x6,
                "l40sx1" => CreateScheduledJobsScheduleResponseJobSpecFlavor.L40sx1,
                "l40sx4" => CreateScheduledJobsScheduleResponseJobSpecFlavor.L40sx4,
                "l40sx8" => CreateScheduledJobsScheduleResponseJobSpecFlavor.L40sx8,
                "l4x1" => CreateScheduledJobsScheduleResponseJobSpecFlavor.L4x1,
                "l4x4" => CreateScheduledJobsScheduleResponseJobSpecFlavor.L4x4,
                "sprx8" => CreateScheduledJobsScheduleResponseJobSpecFlavor.Sprx8,
                "t4-medium" => CreateScheduledJobsScheduleResponseJobSpecFlavor.T4Medium,
                "t4-small" => CreateScheduledJobsScheduleResponseJobSpecFlavor.T4Small,
                "zero-a10g" => CreateScheduledJobsScheduleResponseJobSpecFlavor.ZeroA10g,
                _ => null,
            };
        }
    }
}