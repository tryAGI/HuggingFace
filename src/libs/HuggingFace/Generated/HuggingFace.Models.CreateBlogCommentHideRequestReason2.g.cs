
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateBlogCommentHideRequestReason2
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
    public static class CreateBlogCommentHideRequestReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentHideRequestReason2 value)
        {
            return value switch
            {
                CreateBlogCommentHideRequestReason2.Abuse => "Abuse",
                CreateBlogCommentHideRequestReason2.GraphicContent => "Graphic Content",
                CreateBlogCommentHideRequestReason2.LowQuality => "Low Quality",
                CreateBlogCommentHideRequestReason2.OffTopic => "Off-Topic",
                CreateBlogCommentHideRequestReason2.Resolved => "Resolved",
                CreateBlogCommentHideRequestReason2.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentHideRequestReason2? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreateBlogCommentHideRequestReason2.Abuse,
                "Graphic Content" => CreateBlogCommentHideRequestReason2.GraphicContent,
                "Low Quality" => CreateBlogCommentHideRequestReason2.LowQuality,
                "Off-Topic" => CreateBlogCommentHideRequestReason2.OffTopic,
                "Resolved" => CreateBlogCommentHideRequestReason2.Resolved,
                "Spam" => CreateBlogCommentHideRequestReason2.Spam,
                _ => null,
            };
        }
    }
}