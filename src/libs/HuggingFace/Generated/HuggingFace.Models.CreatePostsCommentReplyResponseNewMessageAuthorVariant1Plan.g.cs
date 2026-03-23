
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan
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
    public static class CreatePostsCommentReplyResponseNewMessageAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan value)
        {
            return value switch
            {
                CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan.Academia => "academia",
                CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan.Enterprise => "enterprise",
                CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan.Plus => "plus",
                CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan.Academia,
                "enterprise" => CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan.Enterprise,
                "plus" => CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan.Plus,
                "team" => CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}