
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataHiddenReason7
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
    public static class ResponseNewMessageDataHiddenReason7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataHiddenReason7 value)
        {
            return value switch
            {
                ResponseNewMessageDataHiddenReason7.Spam => "Spam",
                ResponseNewMessageDataHiddenReason7.Abuse => "Abuse",
                ResponseNewMessageDataHiddenReason7.GraphicContent => "Graphic Content",
                ResponseNewMessageDataHiddenReason7.Resolved => "Resolved",
                ResponseNewMessageDataHiddenReason7.OffTopic => "Off-Topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataHiddenReason7? ToEnum(string value)
        {
            return value switch
            {
                "Spam" => ResponseNewMessageDataHiddenReason7.Spam,
                "Abuse" => ResponseNewMessageDataHiddenReason7.Abuse,
                "Graphic Content" => ResponseNewMessageDataHiddenReason7.GraphicContent,
                "Resolved" => ResponseNewMessageDataHiddenReason7.Resolved,
                "Off-Topic" => ResponseNewMessageDataHiddenReason7.OffTopic,
                _ => null,
            };
        }
    }
}