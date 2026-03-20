
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemType7
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Directory,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemType7 value)
        {
            return value switch
            {
                ResponseItemType7.File => "file",
                ResponseItemType7.Directory => "directory",
                ResponseItemType7.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemType7? ToEnum(string value)
        {
            return value switch
            {
                "file" => ResponseItemType7.File,
                "directory" => ResponseItemType7.Directory,
                "unknown" => ResponseItemType7.Unknown,
                _ => null,
            };
        }
    }
}