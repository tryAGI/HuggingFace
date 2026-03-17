
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemType4
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
    public static class ResponseItemType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemType4 value)
        {
            return value switch
            {
                ResponseItemType4.File => "file",
                ResponseItemType4.Directory => "directory",
                ResponseItemType4.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemType4? ToEnum(string value)
        {
            return value switch
            {
                "file" => ResponseItemType4.File,
                "directory" => ResponseItemType4.Directory,
                "unknown" => ResponseItemType4.Unknown,
                _ => null,
            };
        }
    }
}