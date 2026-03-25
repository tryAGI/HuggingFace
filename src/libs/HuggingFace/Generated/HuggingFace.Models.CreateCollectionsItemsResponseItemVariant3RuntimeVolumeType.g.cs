
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType
    {
        /// <summary>
        /// 
        /// </summary>
        Bucket,
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
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCollectionsItemsResponseItemVariant3RuntimeVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType.Bucket => "bucket",
                CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType.Dataset => "dataset",
                CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType.Model => "model",
                CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType.Bucket,
                "dataset" => CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType.Dataset,
                "model" => CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType.Model,
                "space" => CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType.Space,
                _ => null,
            };
        }
    }
}