
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFileUploadMode
    {
        /// <summary>
        /// 
        /// </summary>
        Lfs,
        /// <summary>
        /// 
        /// </summary>
        Regular,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFileUploadModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFileUploadMode value)
        {
            return value switch
            {
                ResponseFileUploadMode.Lfs => "lfs",
                ResponseFileUploadMode.Regular => "regular",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFileUploadMode? ToEnum(string value)
        {
            return value switch
            {
                "lfs" => ResponseFileUploadMode.Lfs,
                "regular" => ResponseFileUploadMode.Regular,
                _ => null,
            };
        }
    }
}