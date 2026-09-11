
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDiscussionsCommentHideRequestReason
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
    public static class CreateDiscussionsCommentHideRequestReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentHideRequestReason value)
        {
            return value switch
            {
                CreateDiscussionsCommentHideRequestReason.Abuse => "Abuse",
                CreateDiscussionsCommentHideRequestReason.GraphicContent => "Graphic Content",
                CreateDiscussionsCommentHideRequestReason.LowQuality => "Low Quality",
                CreateDiscussionsCommentHideRequestReason.OffTopic => "Off-Topic",
                CreateDiscussionsCommentHideRequestReason.Resolved => "Resolved",
                CreateDiscussionsCommentHideRequestReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentHideRequestReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreateDiscussionsCommentHideRequestReason.Abuse,
                "Graphic Content" => CreateDiscussionsCommentHideRequestReason.GraphicContent,
                "Low Quality" => CreateDiscussionsCommentHideRequestReason.LowQuality,
                "Off-Topic" => CreateDiscussionsCommentHideRequestReason.OffTopic,
                "Resolved" => CreateDiscussionsCommentHideRequestReason.Resolved,
                "Spam" => CreateDiscussionsCommentHideRequestReason.Spam,
                _ => null,
            };
        }
    }
}