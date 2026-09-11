
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateBlogCommentHideRequestReason
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
    public static class CreateBlogCommentHideRequestReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentHideRequestReason value)
        {
            return value switch
            {
                CreateBlogCommentHideRequestReason.Abuse => "Abuse",
                CreateBlogCommentHideRequestReason.GraphicContent => "Graphic Content",
                CreateBlogCommentHideRequestReason.LowQuality => "Low Quality",
                CreateBlogCommentHideRequestReason.OffTopic => "Off-Topic",
                CreateBlogCommentHideRequestReason.Resolved => "Resolved",
                CreateBlogCommentHideRequestReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentHideRequestReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreateBlogCommentHideRequestReason.Abuse,
                "Graphic Content" => CreateBlogCommentHideRequestReason.GraphicContent,
                "Low Quality" => CreateBlogCommentHideRequestReason.LowQuality,
                "Off-Topic" => CreateBlogCommentHideRequestReason.OffTopic,
                "Resolved" => CreateBlogCommentHideRequestReason.Resolved,
                "Spam" => CreateBlogCommentHideRequestReason.Spam,
                _ => null,
            };
        }
    }
}