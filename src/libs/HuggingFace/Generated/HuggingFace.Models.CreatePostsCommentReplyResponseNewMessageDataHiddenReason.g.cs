
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentReplyResponseNewMessageDataHiddenReason
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
        LowQuality,
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
    public static class CreatePostsCommentReplyResponseNewMessageDataHiddenReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentReplyResponseNewMessageDataHiddenReason value)
        {
            return value switch
            {
                CreatePostsCommentReplyResponseNewMessageDataHiddenReason.Abuse => "Abuse",
                CreatePostsCommentReplyResponseNewMessageDataHiddenReason.GraphicContent => "Graphic Content",
                CreatePostsCommentReplyResponseNewMessageDataHiddenReason.LowQuality => "Low Quality",
                CreatePostsCommentReplyResponseNewMessageDataHiddenReason.OffTopic => "Off-Topic",
                CreatePostsCommentReplyResponseNewMessageDataHiddenReason.Resolved => "Resolved",
                CreatePostsCommentReplyResponseNewMessageDataHiddenReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentReplyResponseNewMessageDataHiddenReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreatePostsCommentReplyResponseNewMessageDataHiddenReason.Abuse,
                "Graphic Content" => CreatePostsCommentReplyResponseNewMessageDataHiddenReason.GraphicContent,
                "Low Quality" => CreatePostsCommentReplyResponseNewMessageDataHiddenReason.LowQuality,
                "Off-Topic" => CreatePostsCommentReplyResponseNewMessageDataHiddenReason.OffTopic,
                "Resolved" => CreatePostsCommentReplyResponseNewMessageDataHiddenReason.Resolved,
                "Spam" => CreatePostsCommentReplyResponseNewMessageDataHiddenReason.Spam,
                _ => null,
            };
        }
    }
}