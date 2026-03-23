
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsRequestItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Collection,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Paper,
        /// <summary>
        /// 
        /// </summary>
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCollectionsItemsRequestItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsRequestItemType value)
        {
            return value switch
            {
                CreateCollectionsItemsRequestItemType.Collection => "collection",
                CreateCollectionsItemsRequestItemType.Dataset => "dataset",
                CreateCollectionsItemsRequestItemType.Model => "model",
                CreateCollectionsItemsRequestItemType.Paper => "paper",
                CreateCollectionsItemsRequestItemType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsRequestItemType? ToEnum(string value)
        {
            return value switch
            {
                "collection" => CreateCollectionsItemsRequestItemType.Collection,
                "dataset" => CreateCollectionsItemsRequestItemType.Dataset,
                "model" => CreateCollectionsItemsRequestItemType.Model,
                "paper" => CreateCollectionsItemsRequestItemType.Paper,
                "space" => CreateCollectionsItemsRequestItemType.Space,
                _ => null,
            };
        }
    }
}