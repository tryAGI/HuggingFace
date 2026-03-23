
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsPathsInfoResponseItemType
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
    public static class CreateDatasetsPathsInfoResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsPathsInfoResponseItemType value)
        {
            return value switch
            {
                CreateDatasetsPathsInfoResponseItemType.Directory => "directory",
                CreateDatasetsPathsInfoResponseItemType.File => "file",
                CreateDatasetsPathsInfoResponseItemType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsPathsInfoResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "directory" => CreateDatasetsPathsInfoResponseItemType.Directory,
                "file" => CreateDatasetsPathsInfoResponseItemType.File,
                "unknown" => CreateDatasetsPathsInfoResponseItemType.Unknown,
                _ => null,
            };
        }
    }
}