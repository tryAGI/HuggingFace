
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3RuntimeVolumeType
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
    public static class PatchCollectionsResponseDataItemVariant3RuntimeVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3RuntimeVolumeType value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3RuntimeVolumeType.Bucket => "bucket",
                PatchCollectionsResponseDataItemVariant3RuntimeVolumeType.Dataset => "dataset",
                PatchCollectionsResponseDataItemVariant3RuntimeVolumeType.Model => "model",
                PatchCollectionsResponseDataItemVariant3RuntimeVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3RuntimeVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchCollectionsResponseDataItemVariant3RuntimeVolumeType.Bucket,
                "dataset" => PatchCollectionsResponseDataItemVariant3RuntimeVolumeType.Dataset,
                "model" => PatchCollectionsResponseDataItemVariant3RuntimeVolumeType.Model,
                "space" => PatchCollectionsResponseDataItemVariant3RuntimeVolumeType.Space,
                _ => null,
            };
        }
    }
}