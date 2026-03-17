
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseAuthAccessTokenFineGrainedGlobalItem
    {
        /// <summary>
        /// 
        /// </summary>
        DiscussionWrite,
        /// <summary>
        /// 
        /// </summary>
        PostWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseAuthAccessTokenFineGrainedGlobalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAuthAccessTokenFineGrainedGlobalItem value)
        {
            return value switch
            {
                ResponseAuthAccessTokenFineGrainedGlobalItem.DiscussionWrite => "discussion.write",
                ResponseAuthAccessTokenFineGrainedGlobalItem.PostWrite => "post.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAuthAccessTokenFineGrainedGlobalItem? ToEnum(string value)
        {
            return value switch
            {
                "discussion.write" => ResponseAuthAccessTokenFineGrainedGlobalItem.DiscussionWrite,
                "post.write" => ResponseAuthAccessTokenFineGrainedGlobalItem.PostWrite,
                _ => null,
            };
        }
    }
}