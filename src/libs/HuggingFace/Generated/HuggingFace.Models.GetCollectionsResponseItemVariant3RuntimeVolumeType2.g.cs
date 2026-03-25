
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3RuntimeVolumeType2
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
    public static class GetCollectionsResponseItemVariant3RuntimeVolumeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3RuntimeVolumeType2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3RuntimeVolumeType2.Bucket => "bucket",
                GetCollectionsResponseItemVariant3RuntimeVolumeType2.Dataset => "dataset",
                GetCollectionsResponseItemVariant3RuntimeVolumeType2.Model => "model",
                GetCollectionsResponseItemVariant3RuntimeVolumeType2.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3RuntimeVolumeType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetCollectionsResponseItemVariant3RuntimeVolumeType2.Bucket,
                "dataset" => GetCollectionsResponseItemVariant3RuntimeVolumeType2.Dataset,
                "model" => GetCollectionsResponseItemVariant3RuntimeVolumeType2.Model,
                "space" => GetCollectionsResponseItemVariant3RuntimeVolumeType2.Space,
                _ => null,
            };
        }
    }
}