
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2
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
    public static class CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Academia => "academia",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Plus => "plus",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Academia,
                "enterprise" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Plus,
                "team" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Team,
                _ => null,
            };
        }
    }
}