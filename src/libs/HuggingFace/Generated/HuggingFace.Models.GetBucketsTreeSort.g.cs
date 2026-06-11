
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Sort order. `path` (default) sorts lexicographically; `uploadedAt` sorts by most recent upload first. In recursive mode `uploadedAt` is only supported at the bucket root (no path prefix). In non-recursive mode, only supported at root or exact folder prefixes.<br/>
    /// Default Value: path
    /// </summary>
    public enum GetBucketsTreeSort
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
    public static class GetBucketsTreeSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBucketsTreeSort value)
        {
            return value switch
            {
                GetBucketsTreeSort.Path => "path",
                GetBucketsTreeSort.UploadedAt => "uploadedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBucketsTreeSort? ToEnum(string value)
        {
            return value switch
            {
                "path" => GetBucketsTreeSort.Path,
                "uploadedAt" => GetBucketsTreeSort.UploadedAt,
                _ => null,
            };
        }
    }
}