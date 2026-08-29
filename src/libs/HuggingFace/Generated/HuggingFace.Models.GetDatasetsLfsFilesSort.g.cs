
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: size
    /// </summary>
    public enum GetDatasetsLfsFilesSort
    {
        /// <summary>
        ///
        /// </summary>
        PushedAt,
        /// <summary>
        ///
        /// </summary>
        Size,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDatasetsLfsFilesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsLfsFilesSort value)
        {
            return value switch
            {
                GetDatasetsLfsFilesSort.PushedAt => "pushedAt",
                GetDatasetsLfsFilesSort.Size => "size",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsLfsFilesSort? ToEnum(string value)
        {
            return value switch
            {
                "pushedAt" => GetDatasetsLfsFilesSort.PushedAt,
                "size" => GetDatasetsLfsFilesSort.Size,
                _ => null,
            };
        }
    }
}