
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Whether the repo is owned by a user or an organization
    /// </summary>
    public enum GetQuicksearchResponseModelAuthorType
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
    public static class GetQuicksearchResponseModelAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetQuicksearchResponseModelAuthorType value)
        {
            return value switch
            {
                GetQuicksearchResponseModelAuthorType.Org => "org",
                GetQuicksearchResponseModelAuthorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetQuicksearchResponseModelAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetQuicksearchResponseModelAuthorType.Org,
                "user" => GetQuicksearchResponseModelAuthorType.User,
                _ => null,
            };
        }
    }
}