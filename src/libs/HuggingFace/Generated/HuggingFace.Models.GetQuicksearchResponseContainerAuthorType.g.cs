
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Whether the repo is owned by a user or an organization
    /// </summary>
    public enum GetQuicksearchResponseContainerAuthorType
    {
        /// <summary>
        ///
        /// </summary>
        Org,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetQuicksearchResponseContainerAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetQuicksearchResponseContainerAuthorType value)
        {
            return value switch
            {
                GetQuicksearchResponseContainerAuthorType.Org => "org",
                GetQuicksearchResponseContainerAuthorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetQuicksearchResponseContainerAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetQuicksearchResponseContainerAuthorType.Org,
                "user" => GetQuicksearchResponseContainerAuthorType.User,
                _ => null,
            };
        }
    }
}