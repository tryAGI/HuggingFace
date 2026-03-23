
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsRequestArch
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
    public static class CreateJobsRequestArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsRequestArch value)
        {
            return value switch
            {
                CreateJobsRequestArch.Amd64 => "amd64",
                CreateJobsRequestArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsRequestArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => CreateJobsRequestArch.Amd64,
                "arm64" => CreateJobsRequestArch.Arm64,
                _ => null,
            };
        }
    }
}