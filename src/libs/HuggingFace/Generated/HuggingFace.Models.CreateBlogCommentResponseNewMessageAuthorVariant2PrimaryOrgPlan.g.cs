
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan
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
    public static class CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}