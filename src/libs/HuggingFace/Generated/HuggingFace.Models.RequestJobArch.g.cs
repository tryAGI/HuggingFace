
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestJobArch
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
    public static class RequestJobArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestJobArch value)
        {
            return value switch
            {
                RequestJobArch.Amd64 => "amd64",
                RequestJobArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestJobArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => RequestJobArch.Amd64,
                "arm64" => RequestJobArch.Arm64,
                _ => null,
            };
        }
    }
}