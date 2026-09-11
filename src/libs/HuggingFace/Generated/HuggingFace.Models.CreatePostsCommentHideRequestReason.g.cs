
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatePostsCommentHideRequestReason
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
    public static class CreatePostsCommentHideRequestReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentHideRequestReason value)
        {
            return value switch
            {
                CreatePostsCommentHideRequestReason.Abuse => "Abuse",
                CreatePostsCommentHideRequestReason.GraphicContent => "Graphic Content",
                CreatePostsCommentHideRequestReason.LowQuality => "Low Quality",
                CreatePostsCommentHideRequestReason.OffTopic => "Off-Topic",
                CreatePostsCommentHideRequestReason.Resolved => "Resolved",
                CreatePostsCommentHideRequestReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentHideRequestReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreatePostsCommentHideRequestReason.Abuse,
                "Graphic Content" => CreatePostsCommentHideRequestReason.GraphicContent,
                "Low Quality" => CreatePostsCommentHideRequestReason.LowQuality,
                "Off-Topic" => CreatePostsCommentHideRequestReason.OffTopic,
                "Resolved" => CreatePostsCommentHideRequestReason.Resolved,
                "Spam" => CreatePostsCommentHideRequestReason.Spam,
                _ => null,
            };
        }
    }
}