
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2
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
    public static class CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2 value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2.Academia => "academia",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2.Enterprise => "enterprise",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2.Plus => "plus",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2.Academia,
                "enterprise" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2.Enterprise,
                "plus" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2.Plus,
                "team" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2.Team,
                _ => null,
            };
        }
    }
}