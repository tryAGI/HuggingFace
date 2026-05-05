
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutScheduledJobsLabelsResponseJobSpecArch
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
    public static class PutScheduledJobsLabelsResponseJobSpecArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutScheduledJobsLabelsResponseJobSpecArch value)
        {
            return value switch
            {
                PutScheduledJobsLabelsResponseJobSpecArch.Amd64 => "amd64",
                PutScheduledJobsLabelsResponseJobSpecArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutScheduledJobsLabelsResponseJobSpecArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => PutScheduledJobsLabelsResponseJobSpecArch.Amd64,
                "arm64" => PutScheduledJobsLabelsResponseJobSpecArch.Arm64,
                _ => null,
            };
        }
    }
}