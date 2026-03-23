
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan
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
    public static class CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}