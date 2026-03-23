
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2
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
    public static class CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Academia => "academia",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Plus => "plus",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Academia,
                "enterprise" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Plus,
                "team" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Team,
                _ => null,
            };
        }
    }
}