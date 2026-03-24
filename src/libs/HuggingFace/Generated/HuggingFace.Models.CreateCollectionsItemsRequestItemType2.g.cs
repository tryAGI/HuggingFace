
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsRequestItemType2
    {
        /// <summary>
        /// 
        /// </summary>
        Bucket,
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
    public static class CreateCollectionsItemsRequestItemType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsRequestItemType2 value)
        {
            return value switch
            {
                CreateCollectionsItemsRequestItemType2.Bucket => "bucket",
                CreateCollectionsItemsRequestItemType2.Collection => "collection",
                CreateCollectionsItemsRequestItemType2.Dataset => "dataset",
                CreateCollectionsItemsRequestItemType2.Model => "model",
                CreateCollectionsItemsRequestItemType2.Paper => "paper",
                CreateCollectionsItemsRequestItemType2.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsRequestItemType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateCollectionsItemsRequestItemType2.Bucket,
                "collection" => CreateCollectionsItemsRequestItemType2.Collection,
                "dataset" => CreateCollectionsItemsRequestItemType2.Dataset,
                "model" => CreateCollectionsItemsRequestItemType2.Model,
                "paper" => CreateCollectionsItemsRequestItemType2.Paper,
                "space" => CreateCollectionsItemsRequestItemType2.Space,
                _ => null,
            };
        }
    }
}