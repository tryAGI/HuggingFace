
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUsersFollowersExpandItem
    {
        /// <summary>
        ///
        /// </summary>
        FollowedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsersFollowersExpandItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsersFollowersExpandItem value)
        {
            return value switch
            {
                GetUsersFollowersExpandItem.FollowedAt => "followedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsersFollowersExpandItem? ToEnum(string value)
        {
            return value switch
            {
                "followedAt" => GetUsersFollowersExpandItem.FollowedAt,
                _ => null,
            };
        }
    }
}