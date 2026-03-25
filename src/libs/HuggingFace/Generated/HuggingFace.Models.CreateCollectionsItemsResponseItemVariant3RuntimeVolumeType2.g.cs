
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType2
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
    public static class CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType2.Bucket => "bucket",
                CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType2.Dataset => "dataset",
                CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType2.Model => "model",
                CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType2.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType2.Bucket,
                "dataset" => CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType2.Dataset,
                "model" => CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType2.Model,
                "space" => CreateCollectionsItemsResponseItemVariant3RuntimeVolumeType2.Space,
                _ => null,
            };
        }
    }
}