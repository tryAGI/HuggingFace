
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan
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
    public static class CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Academia => "academia",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise => "enterprise",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Plus => "plus",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Academia,
                "enterprise" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise,
                "plus" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Plus,
                "team" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}