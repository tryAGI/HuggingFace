
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant1Collection
    {
        /// <summary>
        /// 
        /// </summary>
        CommunityBlogs,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDiscussionsResponseVariant1CollectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant1Collection value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant1Collection.CommunityBlogs => "community_blogs",
                GetDiscussionsResponseVariant1Collection.Discussions => "discussions",
                GetDiscussionsResponseVariant1Collection.PaperDiscussions => "paper_discussions",
                GetDiscussionsResponseVariant1Collection.SocialPosts => "social_posts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant1Collection? ToEnum(string value)
        {
            return value switch
            {
                "community_blogs" => GetDiscussionsResponseVariant1Collection.CommunityBlogs,
                "discussions" => GetDiscussionsResponseVariant1Collection.Discussions,
                "paper_discussions" => GetDiscussionsResponseVariant1Collection.PaperDiscussions,
                "social_posts" => GetDiscussionsResponseVariant1Collection.SocialPosts,
                _ => null,
            };
        }
    }
}