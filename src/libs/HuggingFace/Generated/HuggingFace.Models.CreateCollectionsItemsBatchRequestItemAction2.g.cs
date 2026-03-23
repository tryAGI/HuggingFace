
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsBatchRequestItemAction2
    {
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCollectionsItemsBatchRequestItemAction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsBatchRequestItemAction2 value)
        {
            return value switch
            {
                CreateCollectionsItemsBatchRequestItemAction2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsBatchRequestItemAction2? ToEnum(string value)
        {
            return value switch
            {
                "update" => CreateCollectionsItemsBatchRequestItemAction2.Update,
                _ => null,
            };
        }
    }
}