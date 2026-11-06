
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Whether the repo is owned by a user or an organization
    /// </summary>
    public enum CreateQuicksearchResponseContainerAuthorType
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
    public static class CreateQuicksearchResponseContainerAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchResponseContainerAuthorType value)
        {
            return value switch
            {
                CreateQuicksearchResponseContainerAuthorType.Org => "org",
                CreateQuicksearchResponseContainerAuthorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchResponseContainerAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateQuicksearchResponseContainerAuthorType.Org,
                "user" => CreateQuicksearchResponseContainerAuthorType.User,
                _ => null,
            };
        }
    }
}