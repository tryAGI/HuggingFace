
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetKernelsLikersExpandItem
    {
        /// <summary>
        ///
        /// </summary>
        LikedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKernelsLikersExpandItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsLikersExpandItem value)
        {
            return value switch
            {
                GetKernelsLikersExpandItem.LikedAt => "likedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsLikersExpandItem? ToEnum(string value)
        {
            return value switch
            {
                "likedAt" => GetKernelsLikersExpandItem.LikedAt,
                _ => null,
            };
        }
    }
}