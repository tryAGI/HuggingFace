
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseArch5
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
    public static class ResponseArch5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseArch5 value)
        {
            return value switch
            {
                ResponseArch5.Amd64 => "amd64",
                ResponseArch5.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseArch5? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => ResponseArch5.Amd64,
                "arm64" => ResponseArch5.Arm64,
                _ => null,
            };
        }
    }
}