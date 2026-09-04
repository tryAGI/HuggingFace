
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatePapersCommentReactionRequestAction
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
    public static class CreatePapersCommentReactionRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentReactionRequestAction value)
        {
            return value switch
            {
                CreatePapersCommentReactionRequestAction.Add => "add",
                CreatePapersCommentReactionRequestAction.Remove => "remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentReactionRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "add" => CreatePapersCommentReactionRequestAction.Add,
                "remove" => CreatePapersCommentReactionRequestAction.Remove,
                _ => null,
            };
        }
    }
}