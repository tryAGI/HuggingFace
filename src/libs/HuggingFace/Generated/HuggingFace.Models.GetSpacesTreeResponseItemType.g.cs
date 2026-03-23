
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTreeResponseItemType
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
    public static class GetSpacesTreeResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTreeResponseItemType value)
        {
            return value switch
            {
                GetSpacesTreeResponseItemType.Directory => "directory",
                GetSpacesTreeResponseItemType.File => "file",
                GetSpacesTreeResponseItemType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTreeResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "directory" => GetSpacesTreeResponseItemType.Directory,
                "file" => GetSpacesTreeResponseItemType.File,
                "unknown" => GetSpacesTreeResponseItemType.Unknown,
                _ => null,
            };
        }
    }
}