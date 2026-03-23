
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsResponseItemArch
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
    public static class GetJobsResponseItemArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsResponseItemArch value)
        {
            return value switch
            {
                GetJobsResponseItemArch.Amd64 => "amd64",
                GetJobsResponseItemArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsResponseItemArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => GetJobsResponseItemArch.Amd64,
                "arm64" => GetJobsResponseItemArch.Arm64,
                _ => null,
            };
        }
    }
}