
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Whether the repo is owned by a user or an organization
    /// </summary>
    public enum GetQuicksearchResponseBucketAuthorType
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
    public static class GetQuicksearchResponseBucketAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetQuicksearchResponseBucketAuthorType value)
        {
            return value switch
            {
                GetQuicksearchResponseBucketAuthorType.Org => "org",
                GetQuicksearchResponseBucketAuthorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetQuicksearchResponseBucketAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetQuicksearchResponseBucketAuthorType.Org,
                "user" => GetQuicksearchResponseBucketAuthorType.User,
                _ => null,
            };
        }
    }
}