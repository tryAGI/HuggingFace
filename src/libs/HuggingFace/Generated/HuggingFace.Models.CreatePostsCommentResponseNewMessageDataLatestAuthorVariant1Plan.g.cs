
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan
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
    public static class CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan value)
        {
            return value switch
            {
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Academia => "academia",
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise => "enterprise",
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Plus => "plus",
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Academia,
                "enterprise" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise,
                "plus" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Plus,
                "team" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}