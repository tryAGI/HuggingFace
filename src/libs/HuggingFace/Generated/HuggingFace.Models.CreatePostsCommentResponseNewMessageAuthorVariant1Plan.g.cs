
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentResponseNewMessageAuthorVariant1Plan
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
    public static class CreatePostsCommentResponseNewMessageAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentResponseNewMessageAuthorVariant1Plan value)
        {
            return value switch
            {
                CreatePostsCommentResponseNewMessageAuthorVariant1Plan.Academia => "academia",
                CreatePostsCommentResponseNewMessageAuthorVariant1Plan.Enterprise => "enterprise",
                CreatePostsCommentResponseNewMessageAuthorVariant1Plan.Plus => "plus",
                CreatePostsCommentResponseNewMessageAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentResponseNewMessageAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePostsCommentResponseNewMessageAuthorVariant1Plan.Academia,
                "enterprise" => CreatePostsCommentResponseNewMessageAuthorVariant1Plan.Enterprise,
                "plus" => CreatePostsCommentResponseNewMessageAuthorVariant1Plan.Plus,
                "team" => CreatePostsCommentResponseNewMessageAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}