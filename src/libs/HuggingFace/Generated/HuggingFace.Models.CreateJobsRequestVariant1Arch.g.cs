
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateJobsRequestVariant1Arch
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
    public static class CreateJobsRequestVariant1ArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsRequestVariant1Arch value)
        {
            return value switch
            {
                CreateJobsRequestVariant1Arch.Amd64 => "amd64",
                CreateJobsRequestVariant1Arch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsRequestVariant1Arch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => CreateJobsRequestVariant1Arch.Amd64,
                "arm64" => CreateJobsRequestVariant1Arch.Arm64,
                _ => null,
            };
        }
    }
}