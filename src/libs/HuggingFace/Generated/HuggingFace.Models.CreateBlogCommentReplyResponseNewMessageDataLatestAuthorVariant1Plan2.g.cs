
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2
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
    public static class CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2 value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2.Academia => "academia",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2.Enterprise => "enterprise",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2.Plus => "plus",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2.Academia,
                "enterprise" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2.Enterprise,
                "plus" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2.Plus,
                "team" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2.Team,
                _ => null,
            };
        }
    }
}