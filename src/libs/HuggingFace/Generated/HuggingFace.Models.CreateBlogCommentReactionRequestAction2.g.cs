
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateBlogCommentReactionRequestAction2
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
    public static class CreateBlogCommentReactionRequestAction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReactionRequestAction2 value)
        {
            return value switch
            {
                CreateBlogCommentReactionRequestAction2.Add => "add",
                CreateBlogCommentReactionRequestAction2.Remove => "remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReactionRequestAction2? ToEnum(string value)
        {
            return value switch
            {
                "add" => CreateBlogCommentReactionRequestAction2.Add,
                "remove" => CreateBlogCommentReactionRequestAction2.Remove,
                _ => null,
            };
        }
    }
}