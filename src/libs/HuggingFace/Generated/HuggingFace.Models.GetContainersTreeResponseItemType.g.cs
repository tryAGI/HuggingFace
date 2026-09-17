
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetContainersTreeResponseItemType
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
    public static class GetContainersTreeResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContainersTreeResponseItemType value)
        {
            return value switch
            {
                GetContainersTreeResponseItemType.Directory => "directory",
                GetContainersTreeResponseItemType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContainersTreeResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "directory" => GetContainersTreeResponseItemType.Directory,
                "file" => GetContainersTreeResponseItemType.File,
                _ => null,
            };
        }
    }
}