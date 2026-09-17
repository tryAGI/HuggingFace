
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateContainersPathsInfoResponseItemType
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
    public static class CreateContainersPathsInfoResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContainersPathsInfoResponseItemType value)
        {
            return value switch
            {
                CreateContainersPathsInfoResponseItemType.Directory => "directory",
                CreateContainersPathsInfoResponseItemType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContainersPathsInfoResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "directory" => CreateContainersPathsInfoResponseItemType.Directory,
                "file" => CreateContainersPathsInfoResponseItemType.File,
                _ => null,
            };
        }
    }
}