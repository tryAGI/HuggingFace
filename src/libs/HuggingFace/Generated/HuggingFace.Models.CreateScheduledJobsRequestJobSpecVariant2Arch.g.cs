
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateScheduledJobsRequestJobSpecVariant2Arch
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
    public static class CreateScheduledJobsRequestJobSpecVariant2ArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsRequestJobSpecVariant2Arch value)
        {
            return value switch
            {
                CreateScheduledJobsRequestJobSpecVariant2Arch.Amd64 => "amd64",
                CreateScheduledJobsRequestJobSpecVariant2Arch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsRequestJobSpecVariant2Arch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => CreateScheduledJobsRequestJobSpecVariant2Arch.Amd64,
                "arm64" => CreateScheduledJobsRequestJobSpecVariant2Arch.Arm64,
                _ => null,
            };
        }
    }
}