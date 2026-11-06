
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Whether the repo is owned by a user or an organization
    /// </summary>
    public enum CreateQuicksearchResponseBucketAuthorType
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
    public static class CreateQuicksearchResponseBucketAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchResponseBucketAuthorType value)
        {
            return value switch
            {
                CreateQuicksearchResponseBucketAuthorType.Org => "org",
                CreateQuicksearchResponseBucketAuthorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchResponseBucketAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateQuicksearchResponseBucketAuthorType.Org,
                "user" => CreateQuicksearchResponseBucketAuthorType.User,
                _ => null,
            };
        }
    }
}