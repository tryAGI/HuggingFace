
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataHiddenReason4
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
    public static class ResponseNewMessageDataHiddenReason4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataHiddenReason4 value)
        {
            return value switch
            {
                ResponseNewMessageDataHiddenReason4.Spam => "Spam",
                ResponseNewMessageDataHiddenReason4.Abuse => "Abuse",
                ResponseNewMessageDataHiddenReason4.GraphicContent => "Graphic Content",
                ResponseNewMessageDataHiddenReason4.Resolved => "Resolved",
                ResponseNewMessageDataHiddenReason4.OffTopic => "Off-Topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataHiddenReason4? ToEnum(string value)
        {
            return value switch
            {
                "Spam" => ResponseNewMessageDataHiddenReason4.Spam,
                "Abuse" => ResponseNewMessageDataHiddenReason4.Abuse,
                "Graphic Content" => ResponseNewMessageDataHiddenReason4.GraphicContent,
                "Resolved" => ResponseNewMessageDataHiddenReason4.Resolved,
                "Off-Topic" => ResponseNewMessageDataHiddenReason4.OffTopic,
                _ => null,
            };
        }
    }
}