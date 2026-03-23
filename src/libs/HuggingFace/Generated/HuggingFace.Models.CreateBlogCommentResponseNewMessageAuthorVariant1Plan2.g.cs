
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageAuthorVariant1Plan2
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
    public static class CreateBlogCommentResponseNewMessageAuthorVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageAuthorVariant1Plan2 value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageAuthorVariant1Plan2.Academia => "academia",
                CreateBlogCommentResponseNewMessageAuthorVariant1Plan2.Enterprise => "enterprise",
                CreateBlogCommentResponseNewMessageAuthorVariant1Plan2.Plus => "plus",
                CreateBlogCommentResponseNewMessageAuthorVariant1Plan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageAuthorVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateBlogCommentResponseNewMessageAuthorVariant1Plan2.Academia,
                "enterprise" => CreateBlogCommentResponseNewMessageAuthorVariant1Plan2.Enterprise,
                "plus" => CreateBlogCommentResponseNewMessageAuthorVariant1Plan2.Plus,
                "team" => CreateBlogCommentResponseNewMessageAuthorVariant1Plan2.Team,
                _ => null,
            };
        }
    }
}