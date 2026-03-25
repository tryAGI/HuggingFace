
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3RuntimeVolumeType2
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
    public static class PatchCollectionsResponseDataItemVariant3RuntimeVolumeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3RuntimeVolumeType2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3RuntimeVolumeType2.Bucket => "bucket",
                PatchCollectionsResponseDataItemVariant3RuntimeVolumeType2.Dataset => "dataset",
                PatchCollectionsResponseDataItemVariant3RuntimeVolumeType2.Model => "model",
                PatchCollectionsResponseDataItemVariant3RuntimeVolumeType2.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3RuntimeVolumeType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchCollectionsResponseDataItemVariant3RuntimeVolumeType2.Bucket,
                "dataset" => PatchCollectionsResponseDataItemVariant3RuntimeVolumeType2.Dataset,
                "model" => PatchCollectionsResponseDataItemVariant3RuntimeVolumeType2.Model,
                "space" => PatchCollectionsResponseDataItemVariant3RuntimeVolumeType2.Space,
                _ => null,
            };
        }
    }
}