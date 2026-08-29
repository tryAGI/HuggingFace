
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: size
    /// </summary>
    public enum GetSpacesLfsFilesSort
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
    public static class GetSpacesLfsFilesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesLfsFilesSort value)
        {
            return value switch
            {
                GetSpacesLfsFilesSort.PushedAt => "pushedAt",
                GetSpacesLfsFilesSort.Size => "size",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesLfsFilesSort? ToEnum(string value)
        {
            return value switch
            {
                "pushedAt" => GetSpacesLfsFilesSort.PushedAt,
                "size" => GetSpacesLfsFilesSort.Size,
                _ => null,
            };
        }
    }
}