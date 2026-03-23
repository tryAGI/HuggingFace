
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan
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
    public static class CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan value)
        {
            return value switch
            {
                CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Academia => "academia",
                CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise => "enterprise",
                CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Plus => "plus",
                CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Academia,
                "enterprise" => CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Enterprise,
                "plus" => CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Plus,
                "team" => CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}