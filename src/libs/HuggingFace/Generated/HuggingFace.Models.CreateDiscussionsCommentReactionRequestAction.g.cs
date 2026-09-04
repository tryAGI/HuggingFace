
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDiscussionsCommentReactionRequestAction
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
    public static class CreateDiscussionsCommentReactionRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentReactionRequestAction value)
        {
            return value switch
            {
                CreateDiscussionsCommentReactionRequestAction.Add => "add",
                CreateDiscussionsCommentReactionRequestAction.Remove => "remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentReactionRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "add" => CreateDiscussionsCommentReactionRequestAction.Add,
                "remove" => CreateDiscussionsCommentReactionRequestAction.Remove,
                _ => null,
            };
        }
    }
}