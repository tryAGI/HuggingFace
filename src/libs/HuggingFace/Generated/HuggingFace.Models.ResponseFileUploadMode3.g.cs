
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFileUploadMode3
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
    public static class ResponseFileUploadMode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFileUploadMode3 value)
        {
            return value switch
            {
                ResponseFileUploadMode3.Lfs => "lfs",
                ResponseFileUploadMode3.Regular => "regular",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFileUploadMode3? ToEnum(string value)
        {
            return value switch
            {
                "lfs" => ResponseFileUploadMode3.Lfs,
                "regular" => ResponseFileUploadMode3.Regular,
                _ => null,
            };
        }
    }
}