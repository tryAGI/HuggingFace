
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1Collection
    {
        /// <summary>
        /// 
        /// </summary>
        Discussions,
        /// <summary>
        /// 
        /// </summary>
        PaperDiscussions,
        /// <summary>
        /// 
        /// </summary>
        SocialPosts,
        /// <summary>
        /// 
        /// </summary>
        CommunityBlogs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseVariant1CollectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1Collection value)
        {
            return value switch
            {
                ResponseVariant1Collection.Discussions => "discussions",
                ResponseVariant1Collection.PaperDiscussions => "paper_discussions",
                ResponseVariant1Collection.SocialPosts => "social_posts",
                ResponseVariant1Collection.CommunityBlogs => "community_blogs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1Collection? ToEnum(string value)
        {
            return value switch
            {
                "discussions" => ResponseVariant1Collection.Discussions,
                "paper_discussions" => ResponseVariant1Collection.PaperDiscussions,
                "social_posts" => ResponseVariant1Collection.SocialPosts,
                "community_blogs" => ResponseVariant1Collection.CommunityBlogs,
                _ => null,
            };
        }
    }
}