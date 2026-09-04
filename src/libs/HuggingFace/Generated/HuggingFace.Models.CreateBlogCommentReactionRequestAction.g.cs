
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateBlogCommentReactionRequestAction
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
    public static class CreateBlogCommentReactionRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReactionRequestAction value)
        {
            return value switch
            {
                CreateBlogCommentReactionRequestAction.Add => "add",
                CreateBlogCommentReactionRequestAction.Remove => "remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReactionRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "add" => CreateBlogCommentReactionRequestAction.Add,
                "remove" => CreateBlogCommentReactionRequestAction.Remove,
                _ => null,
            };
        }
    }
}