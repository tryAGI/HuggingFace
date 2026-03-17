
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestJobSpecArch
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
    public static class RequestJobSpecArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestJobSpecArch value)
        {
            return value switch
            {
                RequestJobSpecArch.Amd64 => "amd64",
                RequestJobSpecArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestJobSpecArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => RequestJobSpecArch.Amd64,
                "arm64" => RequestJobSpecArch.Arm64,
                _ => null,
            };
        }
    }
}