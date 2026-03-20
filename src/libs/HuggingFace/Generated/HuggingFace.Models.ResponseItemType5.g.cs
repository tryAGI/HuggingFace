
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemType5
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
    public static class ResponseItemType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemType5 value)
        {
            return value switch
            {
                ResponseItemType5.File => "file",
                ResponseItemType5.Directory => "directory",
                ResponseItemType5.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemType5? ToEnum(string value)
        {
            return value switch
            {
                "file" => ResponseItemType5.File,
                "directory" => ResponseItemType5.Directory,
                "unknown" => ResponseItemType5.Unknown,
                _ => null,
            };
        }
    }
}