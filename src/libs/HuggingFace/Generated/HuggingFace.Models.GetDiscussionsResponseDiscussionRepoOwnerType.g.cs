
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseDiscussionRepoOwnerType
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
    public static class GetDiscussionsResponseDiscussionRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseDiscussionRepoOwnerType value)
        {
            return value switch
            {
                GetDiscussionsResponseDiscussionRepoOwnerType.Org => "org",
                GetDiscussionsResponseDiscussionRepoOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseDiscussionRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetDiscussionsResponseDiscussionRepoOwnerType.Org,
                "user" => GetDiscussionsResponseDiscussionRepoOwnerType.User,
                _ => null,
            };
        }
    }
}