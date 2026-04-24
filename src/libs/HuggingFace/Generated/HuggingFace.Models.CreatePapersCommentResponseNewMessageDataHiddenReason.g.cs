
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentResponseNewMessageDataHiddenReason
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
    public static class CreatePapersCommentResponseNewMessageDataHiddenReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentResponseNewMessageDataHiddenReason value)
        {
            return value switch
            {
                CreatePapersCommentResponseNewMessageDataHiddenReason.Abuse => "Abuse",
                CreatePapersCommentResponseNewMessageDataHiddenReason.GraphicContent => "Graphic Content",
                CreatePapersCommentResponseNewMessageDataHiddenReason.LowQuality => "Low Quality",
                CreatePapersCommentResponseNewMessageDataHiddenReason.OffTopic => "Off-Topic",
                CreatePapersCommentResponseNewMessageDataHiddenReason.Resolved => "Resolved",
                CreatePapersCommentResponseNewMessageDataHiddenReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentResponseNewMessageDataHiddenReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreatePapersCommentResponseNewMessageDataHiddenReason.Abuse,
                "Graphic Content" => CreatePapersCommentResponseNewMessageDataHiddenReason.GraphicContent,
                "Low Quality" => CreatePapersCommentResponseNewMessageDataHiddenReason.LowQuality,
                "Off-Topic" => CreatePapersCommentResponseNewMessageDataHiddenReason.OffTopic,
                "Resolved" => CreatePapersCommentResponseNewMessageDataHiddenReason.Resolved,
                "Spam" => CreatePapersCommentResponseNewMessageDataHiddenReason.Spam,
                _ => null,
            };
        }
    }
}