
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPathsInfoResponseItemType
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
    public static class CreateSpacesPathsInfoResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPathsInfoResponseItemType value)
        {
            return value switch
            {
                CreateSpacesPathsInfoResponseItemType.Directory => "directory",
                CreateSpacesPathsInfoResponseItemType.File => "file",
                CreateSpacesPathsInfoResponseItemType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPathsInfoResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "directory" => CreateSpacesPathsInfoResponseItemType.Directory,
                "file" => CreateSpacesPathsInfoResponseItemType.File,
                "unknown" => CreateSpacesPathsInfoResponseItemType.Unknown,
                _ => null,
            };
        }
    }
}