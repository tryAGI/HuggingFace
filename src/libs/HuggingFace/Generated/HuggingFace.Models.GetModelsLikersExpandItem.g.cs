
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetModelsLikersExpandItem
    {
        /// <summary>
        ///
        /// </summary>
        LikedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsLikersExpandItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsLikersExpandItem value)
        {
            return value switch
            {
                GetModelsLikersExpandItem.LikedAt => "likedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsLikersExpandItem? ToEnum(string value)
        {
            return value switch
            {
                "likedAt" => GetModelsLikersExpandItem.LikedAt,
                _ => null,
            };
        }
    }
}