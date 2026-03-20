
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemType8
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
    public static class ResponseItemType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemType8 value)
        {
            return value switch
            {
                ResponseItemType8.File => "file",
                ResponseItemType8.Directory => "directory",
                ResponseItemType8.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemType8? ToEnum(string value)
        {
            return value switch
            {
                "file" => ResponseItemType8.File,
                "directory" => ResponseItemType8.Directory,
                "unknown" => ResponseItemType8.Unknown,
                _ => null,
            };
        }
    }
}