
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDatasetsLikersExpandItem
    {
        /// <summary>
        ///
        /// </summary>
        LikedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDatasetsLikersExpandItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsLikersExpandItem value)
        {
            return value switch
            {
                GetDatasetsLikersExpandItem.LikedAt => "likedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsLikersExpandItem? ToEnum(string value)
        {
            return value switch
            {
                "likedAt" => GetDatasetsLikersExpandItem.LikedAt,
                _ => null,
            };
        }
    }
}