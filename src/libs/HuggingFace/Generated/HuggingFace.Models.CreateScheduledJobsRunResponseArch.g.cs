
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsRunResponseArch
    {
        /// <summary>
        /// 
        /// </summary>
        Amd64,
        /// <summary>
        /// 
        /// </summary>
        Arm64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateScheduledJobsRunResponseArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsRunResponseArch value)
        {
            return value switch
            {
                CreateScheduledJobsRunResponseArch.Amd64 => "amd64",
                CreateScheduledJobsRunResponseArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsRunResponseArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => CreateScheduledJobsRunResponseArch.Amd64,
                "arm64" => CreateScheduledJobsRunResponseArch.Arm64,
                _ => null,
            };
        }
    }
}