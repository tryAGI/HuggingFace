
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsRequestItemType
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
    public static class CreateCollectionsRequestItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsRequestItemType value)
        {
            return value switch
            {
                CreateCollectionsRequestItemType.Collection => "collection",
                CreateCollectionsRequestItemType.Dataset => "dataset",
                CreateCollectionsRequestItemType.Model => "model",
                CreateCollectionsRequestItemType.Paper => "paper",
                CreateCollectionsRequestItemType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsRequestItemType? ToEnum(string value)
        {
            return value switch
            {
                "collection" => CreateCollectionsRequestItemType.Collection,
                "dataset" => CreateCollectionsRequestItemType.Dataset,
                "model" => CreateCollectionsRequestItemType.Model,
                "paper" => CreateCollectionsRequestItemType.Paper,
                "space" => CreateCollectionsRequestItemType.Space,
                _ => null,
            };
        }
    }
}