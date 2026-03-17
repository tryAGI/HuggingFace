
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataHiddenReason9
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
    public static class ResponseNewMessageDataHiddenReason9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataHiddenReason9 value)
        {
            return value switch
            {
                ResponseNewMessageDataHiddenReason9.Spam => "Spam",
                ResponseNewMessageDataHiddenReason9.Abuse => "Abuse",
                ResponseNewMessageDataHiddenReason9.GraphicContent => "Graphic Content",
                ResponseNewMessageDataHiddenReason9.Resolved => "Resolved",
                ResponseNewMessageDataHiddenReason9.OffTopic => "Off-Topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataHiddenReason9? ToEnum(string value)
        {
            return value switch
            {
                "Spam" => ResponseNewMessageDataHiddenReason9.Spam,
                "Abuse" => ResponseNewMessageDataHiddenReason9.Abuse,
                "Graphic Content" => ResponseNewMessageDataHiddenReason9.GraphicContent,
                "Resolved" => ResponseNewMessageDataHiddenReason9.Resolved,
                "Off-Topic" => ResponseNewMessageDataHiddenReason9.OffTopic,
                _ => null,
            };
        }
    }
}