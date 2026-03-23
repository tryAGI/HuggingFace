
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsBatchRequestItemAction
    {
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCollectionsItemsBatchRequestItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsBatchRequestItemAction value)
        {
            return value switch
            {
                CreateCollectionsItemsBatchRequestItemAction.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsBatchRequestItemAction? ToEnum(string value)
        {
            return value switch
            {
                "update" => CreateCollectionsItemsBatchRequestItemAction.Update,
                _ => null,
            };
        }
    }
}