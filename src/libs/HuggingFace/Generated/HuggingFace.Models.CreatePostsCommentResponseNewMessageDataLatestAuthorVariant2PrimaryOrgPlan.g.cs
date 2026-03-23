
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan
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
    public static class CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}