
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageDataHiddenReason
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
    public static class CreateBlogCommentResponseNewMessageDataHiddenReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageDataHiddenReason value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageDataHiddenReason.Abuse => "Abuse",
                CreateBlogCommentResponseNewMessageDataHiddenReason.GraphicContent => "Graphic Content",
                CreateBlogCommentResponseNewMessageDataHiddenReason.LowQuality => "Low Quality",
                CreateBlogCommentResponseNewMessageDataHiddenReason.OffTopic => "Off-Topic",
                CreateBlogCommentResponseNewMessageDataHiddenReason.Resolved => "Resolved",
                CreateBlogCommentResponseNewMessageDataHiddenReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageDataHiddenReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreateBlogCommentResponseNewMessageDataHiddenReason.Abuse,
                "Graphic Content" => CreateBlogCommentResponseNewMessageDataHiddenReason.GraphicContent,
                "Low Quality" => CreateBlogCommentResponseNewMessageDataHiddenReason.LowQuality,
                "Off-Topic" => CreateBlogCommentResponseNewMessageDataHiddenReason.OffTopic,
                "Resolved" => CreateBlogCommentResponseNewMessageDataHiddenReason.Resolved,
                "Spam" => CreateBlogCommentResponseNewMessageDataHiddenReason.Spam,
                _ => null,
            };
        }
    }
}