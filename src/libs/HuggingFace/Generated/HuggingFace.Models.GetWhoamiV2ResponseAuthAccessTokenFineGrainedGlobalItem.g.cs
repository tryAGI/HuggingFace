
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem
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
    public static class GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem value)
        {
            return value switch
            {
                GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem.DiscussionWrite => "discussion.write",
                GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem.PostWrite => "post.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem? ToEnum(string value)
        {
            return value switch
            {
                "discussion.write" => GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem.DiscussionWrite,
                "post.write" => GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem.PostWrite,
                _ => null,
            };
        }
    }
}