
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDiscussionsIgnoreRequestAction
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
    public static class CreateDiscussionsIgnoreRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsIgnoreRequestAction value)
        {
            return value switch
            {
                CreateDiscussionsIgnoreRequestAction.Add => "add",
                CreateDiscussionsIgnoreRequestAction.Remove => "remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsIgnoreRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "add" => CreateDiscussionsIgnoreRequestAction.Add,
                "remove" => CreateDiscussionsIgnoreRequestAction.Remove,
                _ => null,
            };
        }
    }
}