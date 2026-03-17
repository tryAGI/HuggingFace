
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestJobArch2
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
    public static class RequestJobArch2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestJobArch2 value)
        {
            return value switch
            {
                RequestJobArch2.Amd64 => "amd64",
                RequestJobArch2.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestJobArch2? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => RequestJobArch2.Amd64,
                "arm64" => RequestJobArch2.Arm64,
                _ => null,
            };
        }
    }
}