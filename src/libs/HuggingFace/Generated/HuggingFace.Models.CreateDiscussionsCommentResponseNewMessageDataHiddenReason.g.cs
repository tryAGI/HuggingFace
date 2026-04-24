
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsCommentResponseNewMessageDataHiddenReason
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
    public static class CreateDiscussionsCommentResponseNewMessageDataHiddenReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentResponseNewMessageDataHiddenReason value)
        {
            return value switch
            {
                CreateDiscussionsCommentResponseNewMessageDataHiddenReason.Abuse => "Abuse",
                CreateDiscussionsCommentResponseNewMessageDataHiddenReason.GraphicContent => "Graphic Content",
                CreateDiscussionsCommentResponseNewMessageDataHiddenReason.LowQuality => "Low Quality",
                CreateDiscussionsCommentResponseNewMessageDataHiddenReason.OffTopic => "Off-Topic",
                CreateDiscussionsCommentResponseNewMessageDataHiddenReason.Resolved => "Resolved",
                CreateDiscussionsCommentResponseNewMessageDataHiddenReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentResponseNewMessageDataHiddenReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreateDiscussionsCommentResponseNewMessageDataHiddenReason.Abuse,
                "Graphic Content" => CreateDiscussionsCommentResponseNewMessageDataHiddenReason.GraphicContent,
                "Low Quality" => CreateDiscussionsCommentResponseNewMessageDataHiddenReason.LowQuality,
                "Off-Topic" => CreateDiscussionsCommentResponseNewMessageDataHiddenReason.OffTopic,
                "Resolved" => CreateDiscussionsCommentResponseNewMessageDataHiddenReason.Resolved,
                "Spam" => CreateDiscussionsCommentResponseNewMessageDataHiddenReason.Spam,
                _ => null,
            };
        }
    }
}