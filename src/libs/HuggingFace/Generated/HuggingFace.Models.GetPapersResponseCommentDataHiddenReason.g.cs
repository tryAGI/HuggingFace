
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseCommentDataHiddenReason
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
        LowQuality,
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
    public static class GetPapersResponseCommentDataHiddenReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseCommentDataHiddenReason value)
        {
            return value switch
            {
                GetPapersResponseCommentDataHiddenReason.Abuse => "Abuse",
                GetPapersResponseCommentDataHiddenReason.GraphicContent => "Graphic Content",
                GetPapersResponseCommentDataHiddenReason.LowQuality => "Low Quality",
                GetPapersResponseCommentDataHiddenReason.OffTopic => "Off-Topic",
                GetPapersResponseCommentDataHiddenReason.Resolved => "Resolved",
                GetPapersResponseCommentDataHiddenReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseCommentDataHiddenReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => GetPapersResponseCommentDataHiddenReason.Abuse,
                "Graphic Content" => GetPapersResponseCommentDataHiddenReason.GraphicContent,
                "Low Quality" => GetPapersResponseCommentDataHiddenReason.LowQuality,
                "Off-Topic" => GetPapersResponseCommentDataHiddenReason.OffTopic,
                "Resolved" => GetPapersResponseCommentDataHiddenReason.Resolved,
                "Spam" => GetPapersResponseCommentDataHiddenReason.Spam,
                _ => null,
            };
        }
    }
}