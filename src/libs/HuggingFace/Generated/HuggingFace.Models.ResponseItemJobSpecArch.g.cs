
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemJobSpecArch
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
    public static class ResponseItemJobSpecArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemJobSpecArch value)
        {
            return value switch
            {
                ResponseItemJobSpecArch.Amd64 => "amd64",
                ResponseItemJobSpecArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemJobSpecArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => ResponseItemJobSpecArch.Amd64,
                "arm64" => ResponseItemJobSpecArch.Arm64,
                _ => null,
            };
        }
    }
}