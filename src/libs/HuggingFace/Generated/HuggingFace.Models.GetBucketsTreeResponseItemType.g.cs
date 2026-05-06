
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBucketsTreeResponseItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Directory,
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBucketsTreeResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBucketsTreeResponseItemType value)
        {
            return value switch
            {
                GetBucketsTreeResponseItemType.Directory => "directory",
                GetBucketsTreeResponseItemType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBucketsTreeResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "directory" => GetBucketsTreeResponseItemType.Directory,
                "file" => GetBucketsTreeResponseItemType.File,
                _ => null,
            };
        }
    }
}