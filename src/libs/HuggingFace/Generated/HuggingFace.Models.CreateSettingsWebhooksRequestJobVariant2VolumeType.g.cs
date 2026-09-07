
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSettingsWebhooksRequestJobVariant2VolumeType
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
    public static class CreateSettingsWebhooksRequestJobVariant2VolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestJobVariant2VolumeType value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestJobVariant2VolumeType.Bucket => "bucket",
                CreateSettingsWebhooksRequestJobVariant2VolumeType.Dataset => "dataset",
                CreateSettingsWebhooksRequestJobVariant2VolumeType.Model => "model",
                CreateSettingsWebhooksRequestJobVariant2VolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestJobVariant2VolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateSettingsWebhooksRequestJobVariant2VolumeType.Bucket,
                "dataset" => CreateSettingsWebhooksRequestJobVariant2VolumeType.Dataset,
                "model" => CreateSettingsWebhooksRequestJobVariant2VolumeType.Model,
                "space" => CreateSettingsWebhooksRequestJobVariant2VolumeType.Space,
                _ => null,
            };
        }
    }
}