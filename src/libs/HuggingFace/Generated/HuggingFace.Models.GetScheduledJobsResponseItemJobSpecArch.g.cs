
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScheduledJobsResponseItemJobSpecArch
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
    public static class GetScheduledJobsResponseItemJobSpecArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScheduledJobsResponseItemJobSpecArch value)
        {
            return value switch
            {
                GetScheduledJobsResponseItemJobSpecArch.Amd64 => "amd64",
                GetScheduledJobsResponseItemJobSpecArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScheduledJobsResponseItemJobSpecArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => GetScheduledJobsResponseItemJobSpecArch.Amd64,
                "arm64" => GetScheduledJobsResponseItemJobSpecArch.Arm64,
                _ => null,
            };
        }
    }
}