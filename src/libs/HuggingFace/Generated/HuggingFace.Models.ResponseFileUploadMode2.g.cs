
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFileUploadMode2
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
    public static class ResponseFileUploadMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFileUploadMode2 value)
        {
            return value switch
            {
                ResponseFileUploadMode2.Lfs => "lfs",
                ResponseFileUploadMode2.Regular => "regular",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFileUploadMode2? ToEnum(string value)
        {
            return value switch
            {
                "lfs" => ResponseFileUploadMode2.Lfs,
                "regular" => ResponseFileUploadMode2.Regular,
                _ => null,
            };
        }
    }
}