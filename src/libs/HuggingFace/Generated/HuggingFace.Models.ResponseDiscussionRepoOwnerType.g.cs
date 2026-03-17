
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDiscussionRepoOwnerType
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
    public static class ResponseDiscussionRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDiscussionRepoOwnerType value)
        {
            return value switch
            {
                ResponseDiscussionRepoOwnerType.Org => "org",
                ResponseDiscussionRepoOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDiscussionRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => ResponseDiscussionRepoOwnerType.Org,
                "user" => ResponseDiscussionRepoOwnerType.User,
                _ => null,
            };
        }
    }
}