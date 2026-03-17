
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemArch
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
    public static class ResponseItemArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemArch value)
        {
            return value switch
            {
                ResponseItemArch.Amd64 => "amd64",
                ResponseItemArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => ResponseItemArch.Amd64,
                "arm64" => ResponseItemArch.Arm64,
                _ => null,
            };
        }
    }
}