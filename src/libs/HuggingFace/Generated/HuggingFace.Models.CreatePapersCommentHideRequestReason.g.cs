
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatePapersCommentHideRequestReason
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
    public static class CreatePapersCommentHideRequestReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentHideRequestReason value)
        {
            return value switch
            {
                CreatePapersCommentHideRequestReason.Abuse => "Abuse",
                CreatePapersCommentHideRequestReason.GraphicContent => "Graphic Content",
                CreatePapersCommentHideRequestReason.LowQuality => "Low Quality",
                CreatePapersCommentHideRequestReason.OffTopic => "Off-Topic",
                CreatePapersCommentHideRequestReason.Resolved => "Resolved",
                CreatePapersCommentHideRequestReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentHideRequestReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreatePapersCommentHideRequestReason.Abuse,
                "Graphic Content" => CreatePapersCommentHideRequestReason.GraphicContent,
                "Low Quality" => CreatePapersCommentHideRequestReason.LowQuality,
                "Off-Topic" => CreatePapersCommentHideRequestReason.OffTopic,
                "Resolved" => CreatePapersCommentHideRequestReason.Resolved,
                "Spam" => CreatePapersCommentHideRequestReason.Spam,
                _ => null,
            };
        }
    }
}