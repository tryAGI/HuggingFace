
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageAuthorVariant1Plan
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
    public static class CreateBlogCommentResponseNewMessageAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageAuthorVariant1Plan value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageAuthorVariant1Plan.Academia => "academia",
                CreateBlogCommentResponseNewMessageAuthorVariant1Plan.Enterprise => "enterprise",
                CreateBlogCommentResponseNewMessageAuthorVariant1Plan.Plus => "plus",
                CreateBlogCommentResponseNewMessageAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateBlogCommentResponseNewMessageAuthorVariant1Plan.Academia,
                "enterprise" => CreateBlogCommentResponseNewMessageAuthorVariant1Plan.Enterprise,
                "plus" => CreateBlogCommentResponseNewMessageAuthorVariant1Plan.Plus,
                "team" => CreateBlogCommentResponseNewMessageAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}