
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatePostsCommentReactionRequestAction
    {
        /// <summary>
        ///
        /// </summary>
        Add,
        /// <summary>
        ///
        /// </summary>
        Remove,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePostsCommentReactionRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentReactionRequestAction value)
        {
            return value switch
            {
                CreatePostsCommentReactionRequestAction.Add => "add",
                CreatePostsCommentReactionRequestAction.Remove => "remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentReactionRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "add" => CreatePostsCommentReactionRequestAction.Add,
                "remove" => CreatePostsCommentReactionRequestAction.Remove,
                _ => null,
            };
        }
    }
}