
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataHiddenReason8
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
    public static class ResponseNewMessageDataHiddenReason8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataHiddenReason8 value)
        {
            return value switch
            {
                ResponseNewMessageDataHiddenReason8.Spam => "Spam",
                ResponseNewMessageDataHiddenReason8.Abuse => "Abuse",
                ResponseNewMessageDataHiddenReason8.GraphicContent => "Graphic Content",
                ResponseNewMessageDataHiddenReason8.Resolved => "Resolved",
                ResponseNewMessageDataHiddenReason8.OffTopic => "Off-Topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataHiddenReason8? ToEnum(string value)
        {
            return value switch
            {
                "Spam" => ResponseNewMessageDataHiddenReason8.Spam,
                "Abuse" => ResponseNewMessageDataHiddenReason8.Abuse,
                "Graphic Content" => ResponseNewMessageDataHiddenReason8.GraphicContent,
                "Resolved" => ResponseNewMessageDataHiddenReason8.Resolved,
                "Off-Topic" => ResponseNewMessageDataHiddenReason8.OffTopic,
                _ => null,
            };
        }
    }
}