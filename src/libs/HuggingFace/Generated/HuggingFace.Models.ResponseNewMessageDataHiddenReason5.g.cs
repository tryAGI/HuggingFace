
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataHiddenReason5
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
    public static class ResponseNewMessageDataHiddenReason5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataHiddenReason5 value)
        {
            return value switch
            {
                ResponseNewMessageDataHiddenReason5.Spam => "Spam",
                ResponseNewMessageDataHiddenReason5.Abuse => "Abuse",
                ResponseNewMessageDataHiddenReason5.GraphicContent => "Graphic Content",
                ResponseNewMessageDataHiddenReason5.Resolved => "Resolved",
                ResponseNewMessageDataHiddenReason5.OffTopic => "Off-Topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataHiddenReason5? ToEnum(string value)
        {
            return value switch
            {
                "Spam" => ResponseNewMessageDataHiddenReason5.Spam,
                "Abuse" => ResponseNewMessageDataHiddenReason5.Abuse,
                "Graphic Content" => ResponseNewMessageDataHiddenReason5.GraphicContent,
                "Resolved" => ResponseNewMessageDataHiddenReason5.Resolved,
                "Off-Topic" => ResponseNewMessageDataHiddenReason5.OffTopic,
                _ => null,
            };
        }
    }
}