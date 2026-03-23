
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant2EventVariant1DataHiddenReason
    {
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
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        Spam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDiscussionsResponseVariant2EventVariant1DataHiddenReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant2EventVariant1DataHiddenReason value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant2EventVariant1DataHiddenReason.Abuse => "Abuse",
                GetDiscussionsResponseVariant2EventVariant1DataHiddenReason.GraphicContent => "Graphic Content",
                GetDiscussionsResponseVariant2EventVariant1DataHiddenReason.OffTopic => "Off-Topic",
                GetDiscussionsResponseVariant2EventVariant1DataHiddenReason.Resolved => "Resolved",
                GetDiscussionsResponseVariant2EventVariant1DataHiddenReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant2EventVariant1DataHiddenReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => GetDiscussionsResponseVariant2EventVariant1DataHiddenReason.Abuse,
                "Graphic Content" => GetDiscussionsResponseVariant2EventVariant1DataHiddenReason.GraphicContent,
                "Off-Topic" => GetDiscussionsResponseVariant2EventVariant1DataHiddenReason.OffTopic,
                "Resolved" => GetDiscussionsResponseVariant2EventVariant1DataHiddenReason.Resolved,
                "Spam" => GetDiscussionsResponseVariant2EventVariant1DataHiddenReason.Spam,
                _ => null,
            };
        }
    }
}