
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2
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
    public static class CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Academia => "academia",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Plus => "plus",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Academia,
                "enterprise" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Plus,
                "team" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Team,
                _ => null,
            };
        }
    }
}