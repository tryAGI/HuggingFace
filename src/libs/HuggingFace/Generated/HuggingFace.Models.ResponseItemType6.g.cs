
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemType6
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
    public static class ResponseItemType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemType6 value)
        {
            return value switch
            {
                ResponseItemType6.File => "file",
                ResponseItemType6.Directory => "directory",
                ResponseItemType6.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemType6? ToEnum(string value)
        {
            return value switch
            {
                "file" => ResponseItemType6.File,
                "directory" => ResponseItemType6.Directory,
                "unknown" => ResponseItemType6.Unknown,
                _ => null,
            };
        }
    }
}