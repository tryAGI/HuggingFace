
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemType3
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
    public static class ResponseItemType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemType3 value)
        {
            return value switch
            {
                ResponseItemType3.File => "file",
                ResponseItemType3.Directory => "directory",
                ResponseItemType3.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemType3? ToEnum(string value)
        {
            return value switch
            {
                "file" => ResponseItemType3.File,
                "directory" => ResponseItemType3.Directory,
                "unknown" => ResponseItemType3.Unknown,
                _ => null,
            };
        }
    }
}