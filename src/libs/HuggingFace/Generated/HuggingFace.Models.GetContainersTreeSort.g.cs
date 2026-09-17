
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Sort order. `path` (default) sorts lexicographically; `uploadedAt` sorts by most recent upload first. In recursive mode `uploadedAt` is only supported at the bucket root (no path prefix). In non-recursive mode, only supported at root or exact folder prefixes.<br/>
    /// Default Value: path
    /// </summary>
    public enum GetContainersTreeSort
    {
        /// <summary>
        ///
        /// </summary>
        Path,
        /// <summary>
        ///
        /// </summary>
        UploadedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetContainersTreeSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContainersTreeSort value)
        {
            return value switch
            {
                GetContainersTreeSort.Path => "path",
                GetContainersTreeSort.UploadedAt => "uploadedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContainersTreeSort? ToEnum(string value)
        {
            return value switch
            {
                "path" => GetContainersTreeSort.Path,
                "uploadedAt" => GetContainersTreeSort.UploadedAt,
                _ => null,
            };
        }
    }
}