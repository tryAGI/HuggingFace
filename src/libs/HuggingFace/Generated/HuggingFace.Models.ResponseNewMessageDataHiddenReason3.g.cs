
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataHiddenReason3
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
    public static class ResponseNewMessageDataHiddenReason3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataHiddenReason3 value)
        {
            return value switch
            {
                ResponseNewMessageDataHiddenReason3.Spam => "Spam",
                ResponseNewMessageDataHiddenReason3.Abuse => "Abuse",
                ResponseNewMessageDataHiddenReason3.GraphicContent => "Graphic Content",
                ResponseNewMessageDataHiddenReason3.Resolved => "Resolved",
                ResponseNewMessageDataHiddenReason3.OffTopic => "Off-Topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataHiddenReason3? ToEnum(string value)
        {
            return value switch
            {
                "Spam" => ResponseNewMessageDataHiddenReason3.Spam,
                "Abuse" => ResponseNewMessageDataHiddenReason3.Abuse,
                "Graphic Content" => ResponseNewMessageDataHiddenReason3.GraphicContent,
                "Resolved" => ResponseNewMessageDataHiddenReason3.Resolved,
                "Off-Topic" => ResponseNewMessageDataHiddenReason3.OffTopic,
                _ => null,
            };
        }
    }
}