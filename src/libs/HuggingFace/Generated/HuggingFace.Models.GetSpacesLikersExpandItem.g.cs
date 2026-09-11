
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSpacesLikersExpandItem
    {
        /// <summary>
        ///
        /// </summary>
        LikedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpacesLikersExpandItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesLikersExpandItem value)
        {
            return value switch
            {
                GetSpacesLikersExpandItem.LikedAt => "likedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesLikersExpandItem? ToEnum(string value)
        {
            return value switch
            {
                "likedAt" => GetSpacesLikersExpandItem.LikedAt,
                _ => null,
            };
        }
    }
}