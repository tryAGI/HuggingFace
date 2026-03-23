
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan
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
    public static class CreateBlogCommentReplyResponseNewMessageAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan.Academia => "academia",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan.Enterprise => "enterprise",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan.Plus => "plus",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan.Academia,
                "enterprise" => CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan.Enterprise,
                "plus" => CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan.Plus,
                "team" => CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}