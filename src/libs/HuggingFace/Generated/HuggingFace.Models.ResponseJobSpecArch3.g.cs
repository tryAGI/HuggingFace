
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseJobSpecArch3
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
    public static class ResponseJobSpecArch3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseJobSpecArch3 value)
        {
            return value switch
            {
                ResponseJobSpecArch3.Amd64 => "amd64",
                ResponseJobSpecArch3.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseJobSpecArch3? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => ResponseJobSpecArch3.Amd64,
                "arm64" => ResponseJobSpecArch3.Arm64,
                _ => null,
            };
        }
    }
}