
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan
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
    public static class CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}