
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentResponseNewMessageDataHiddenReason
    {
        /// <summary>
        /// 
        /// </summary>
        Abuse,
        /// <summary>
        /// 
        /// </summary>
        GraphicContent,
        /// <summary>
        /// 
        /// </summary>
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        Spam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePostsCommentResponseNewMessageDataHiddenReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentResponseNewMessageDataHiddenReason value)
        {
            return value switch
            {
                CreatePostsCommentResponseNewMessageDataHiddenReason.Abuse => "Abuse",
                CreatePostsCommentResponseNewMessageDataHiddenReason.GraphicContent => "Graphic Content",
                CreatePostsCommentResponseNewMessageDataHiddenReason.OffTopic => "Off-Topic",
                CreatePostsCommentResponseNewMessageDataHiddenReason.Resolved => "Resolved",
                CreatePostsCommentResponseNewMessageDataHiddenReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentResponseNewMessageDataHiddenReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreatePostsCommentResponseNewMessageDataHiddenReason.Abuse,
                "Graphic Content" => CreatePostsCommentResponseNewMessageDataHiddenReason.GraphicContent,
                "Off-Topic" => CreatePostsCommentResponseNewMessageDataHiddenReason.OffTopic,
                "Resolved" => CreatePostsCommentResponseNewMessageDataHiddenReason.Resolved,
                "Spam" => CreatePostsCommentResponseNewMessageDataHiddenReason.Spam,
                _ => null,
            };
        }
    }
}