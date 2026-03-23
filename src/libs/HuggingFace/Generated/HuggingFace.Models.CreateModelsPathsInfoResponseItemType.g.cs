
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPathsInfoResponseItemType
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
    public static class CreateModelsPathsInfoResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPathsInfoResponseItemType value)
        {
            return value switch
            {
                CreateModelsPathsInfoResponseItemType.Directory => "directory",
                CreateModelsPathsInfoResponseItemType.File => "file",
                CreateModelsPathsInfoResponseItemType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPathsInfoResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "directory" => CreateModelsPathsInfoResponseItemType.Directory,
                "file" => CreateModelsPathsInfoResponseItemType.File,
                "unknown" => CreateModelsPathsInfoResponseItemType.Unknown,
                _ => null,
            };
        }
    }
}