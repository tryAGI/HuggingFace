
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageDataHiddenReason2
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
    public static class CreateBlogCommentResponseNewMessageDataHiddenReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageDataHiddenReason2 value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageDataHiddenReason2.Abuse => "Abuse",
                CreateBlogCommentResponseNewMessageDataHiddenReason2.GraphicContent => "Graphic Content",
                CreateBlogCommentResponseNewMessageDataHiddenReason2.OffTopic => "Off-Topic",
                CreateBlogCommentResponseNewMessageDataHiddenReason2.Resolved => "Resolved",
                CreateBlogCommentResponseNewMessageDataHiddenReason2.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageDataHiddenReason2? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreateBlogCommentResponseNewMessageDataHiddenReason2.Abuse,
                "Graphic Content" => CreateBlogCommentResponseNewMessageDataHiddenReason2.GraphicContent,
                "Off-Topic" => CreateBlogCommentResponseNewMessageDataHiddenReason2.OffTopic,
                "Resolved" => CreateBlogCommentResponseNewMessageDataHiddenReason2.Resolved,
                "Spam" => CreateBlogCommentResponseNewMessageDataHiddenReason2.Spam,
                _ => null,
            };
        }
    }
}