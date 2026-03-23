
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan
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
    public static class CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan.Academia => "academia",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise => "enterprise",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan.Plus => "plus",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan.Academia,
                "enterprise" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise,
                "plus" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan.Plus,
                "team" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}