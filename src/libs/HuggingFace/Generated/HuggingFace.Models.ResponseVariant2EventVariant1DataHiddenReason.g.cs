
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant2EventVariant1DataHiddenReason
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
    public static class ResponseVariant2EventVariant1DataHiddenReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant2EventVariant1DataHiddenReason value)
        {
            return value switch
            {
                ResponseVariant2EventVariant1DataHiddenReason.Spam => "Spam",
                ResponseVariant2EventVariant1DataHiddenReason.Abuse => "Abuse",
                ResponseVariant2EventVariant1DataHiddenReason.GraphicContent => "Graphic Content",
                ResponseVariant2EventVariant1DataHiddenReason.Resolved => "Resolved",
                ResponseVariant2EventVariant1DataHiddenReason.OffTopic => "Off-Topic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant2EventVariant1DataHiddenReason? ToEnum(string value)
        {
            return value switch
            {
                "Spam" => ResponseVariant2EventVariant1DataHiddenReason.Spam,
                "Abuse" => ResponseVariant2EventVariant1DataHiddenReason.Abuse,
                "Graphic Content" => ResponseVariant2EventVariant1DataHiddenReason.GraphicContent,
                "Resolved" => ResponseVariant2EventVariant1DataHiddenReason.Resolved,
                "Off-Topic" => ResponseVariant2EventVariant1DataHiddenReason.OffTopic,
                _ => null,
            };
        }
    }
}