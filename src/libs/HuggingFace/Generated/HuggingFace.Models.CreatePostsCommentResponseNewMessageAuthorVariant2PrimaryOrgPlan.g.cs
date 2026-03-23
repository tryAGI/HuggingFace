
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Academia,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}