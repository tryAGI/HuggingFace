
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataHiddenReason
    {
        /// <summary>
        /// 
        /// </summary>
        Spam,
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
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        OffTopic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseNewMessageDataHiddenReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataHiddenReason value)
        {
            return value switch
            {
                ResponseNewMessageDataHiddenReason.Spam => "Spam",
                ResponseNewMessageDataHiddenReason.Abuse => "Abuse",
                ResponseNewMessageDataHiddenReason.GraphicContent => "Graphic Content",
                ResponseNewMessageDataHiddenReason.Resolved => "Resolved",
                ResponseNewMessageDataHiddenReason.OffTopic => "Off-Topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataHiddenReason? ToEnum(string value)
        {
            return value switch
            {
                "Spam" => ResponseNewMessageDataHiddenReason.Spam,
                "Abuse" => ResponseNewMessageDataHiddenReason.Abuse,
                "Graphic Content" => ResponseNewMessageDataHiddenReason.GraphicContent,
                "Resolved" => ResponseNewMessageDataHiddenReason.Resolved,
                "Off-Topic" => ResponseNewMessageDataHiddenReason.OffTopic,
                _ => null,
            };
        }
    }
}