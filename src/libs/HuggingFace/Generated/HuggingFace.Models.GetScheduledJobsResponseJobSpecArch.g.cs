
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScheduledJobsResponseJobSpecArch
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
    public static class GetScheduledJobsResponseJobSpecArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScheduledJobsResponseJobSpecArch value)
        {
            return value switch
            {
                GetScheduledJobsResponseJobSpecArch.Amd64 => "amd64",
                GetScheduledJobsResponseJobSpecArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScheduledJobsResponseJobSpecArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => GetScheduledJobsResponseJobSpecArch.Amd64,
                "arm64" => GetScheduledJobsResponseJobSpecArch.Arm64,
                _ => null,
            };
        }
    }
}