
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Whether the repo is owned by a user or an organization
    /// </summary>
    public enum CreateQuicksearchResponseSpaceAuthorType
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
    public static class CreateQuicksearchResponseSpaceAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchResponseSpaceAuthorType value)
        {
            return value switch
            {
                CreateQuicksearchResponseSpaceAuthorType.Org => "org",
                CreateQuicksearchResponseSpaceAuthorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchResponseSpaceAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateQuicksearchResponseSpaceAuthorType.Org,
                "user" => CreateQuicksearchResponseSpaceAuthorType.User,
                _ => null,
            };
        }
    }
}