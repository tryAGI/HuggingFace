
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTreeResponseItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Directory,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDatasetsTreeResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTreeResponseItemType value)
        {
            return value switch
            {
                GetDatasetsTreeResponseItemType.Directory => "directory",
                GetDatasetsTreeResponseItemType.File => "file",
                GetDatasetsTreeResponseItemType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTreeResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "directory" => GetDatasetsTreeResponseItemType.Directory,
                "file" => GetDatasetsTreeResponseItemType.File,
                "unknown" => GetDatasetsTreeResponseItemType.Unknown,
                _ => null,
            };
        }
    }
}