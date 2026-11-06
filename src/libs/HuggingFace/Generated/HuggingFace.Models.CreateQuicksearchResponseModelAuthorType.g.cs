
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Whether the repo is owned by a user or an organization
    /// </summary>
    public enum CreateQuicksearchResponseModelAuthorType
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
    public static class CreateQuicksearchResponseModelAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchResponseModelAuthorType value)
        {
            return value switch
            {
                CreateQuicksearchResponseModelAuthorType.Org => "org",
                CreateQuicksearchResponseModelAuthorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchResponseModelAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateQuicksearchResponseModelAuthorType.Org,
                "user" => CreateQuicksearchResponseModelAuthorType.User,
                _ => null,
            };
        }
    }
}