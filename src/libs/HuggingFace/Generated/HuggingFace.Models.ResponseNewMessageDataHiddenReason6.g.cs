
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataHiddenReason6
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
    public static class ResponseNewMessageDataHiddenReason6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataHiddenReason6 value)
        {
            return value switch
            {
                ResponseNewMessageDataHiddenReason6.Spam => "Spam",
                ResponseNewMessageDataHiddenReason6.Abuse => "Abuse",
                ResponseNewMessageDataHiddenReason6.GraphicContent => "Graphic Content",
                ResponseNewMessageDataHiddenReason6.Resolved => "Resolved",
                ResponseNewMessageDataHiddenReason6.OffTopic => "Off-Topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataHiddenReason6? ToEnum(string value)
        {
            return value switch
            {
                "Spam" => ResponseNewMessageDataHiddenReason6.Spam,
                "Abuse" => ResponseNewMessageDataHiddenReason6.Abuse,
                "Graphic Content" => ResponseNewMessageDataHiddenReason6.GraphicContent,
                "Resolved" => ResponseNewMessageDataHiddenReason6.Resolved,
                "Off-Topic" => ResponseNewMessageDataHiddenReason6.OffTopic,
                _ => null,
            };
        }
    }
}