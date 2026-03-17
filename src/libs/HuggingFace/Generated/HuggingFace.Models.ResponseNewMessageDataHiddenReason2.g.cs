
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataHiddenReason2
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
    public static class ResponseNewMessageDataHiddenReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataHiddenReason2 value)
        {
            return value switch
            {
                ResponseNewMessageDataHiddenReason2.Spam => "Spam",
                ResponseNewMessageDataHiddenReason2.Abuse => "Abuse",
                ResponseNewMessageDataHiddenReason2.GraphicContent => "Graphic Content",
                ResponseNewMessageDataHiddenReason2.Resolved => "Resolved",
                ResponseNewMessageDataHiddenReason2.OffTopic => "Off-Topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataHiddenReason2? ToEnum(string value)
        {
            return value switch
            {
                "Spam" => ResponseNewMessageDataHiddenReason2.Spam,
                "Abuse" => ResponseNewMessageDataHiddenReason2.Abuse,
                "Graphic Content" => ResponseNewMessageDataHiddenReason2.GraphicContent,
                "Resolved" => ResponseNewMessageDataHiddenReason2.Resolved,
                "Off-Topic" => ResponseNewMessageDataHiddenReason2.OffTopic,
                _ => null,
            };
        }
    }
}