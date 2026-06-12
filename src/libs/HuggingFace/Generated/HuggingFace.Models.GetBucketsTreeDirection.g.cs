
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Sort direction. Defaults to `asc` for `path` and `desc` for `uploadedAt`.
    /// </summary>
    public enum GetBucketsTreeDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBucketsTreeDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBucketsTreeDirection value)
        {
            return value switch
            {
                GetBucketsTreeDirection.Asc => "asc",
                GetBucketsTreeDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBucketsTreeDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetBucketsTreeDirection.Asc,
                "desc" => GetBucketsTreeDirection.Desc,
                _ => null,
            };
        }
    }
}