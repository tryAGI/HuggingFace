
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSettingsWebhooksRequestJobVariant2VolumeType2
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
    public static class CreateSettingsWebhooksRequestJobVariant2VolumeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestJobVariant2VolumeType2 value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestJobVariant2VolumeType2.Bucket => "bucket",
                CreateSettingsWebhooksRequestJobVariant2VolumeType2.Dataset => "dataset",
                CreateSettingsWebhooksRequestJobVariant2VolumeType2.Model => "model",
                CreateSettingsWebhooksRequestJobVariant2VolumeType2.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestJobVariant2VolumeType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateSettingsWebhooksRequestJobVariant2VolumeType2.Bucket,
                "dataset" => CreateSettingsWebhooksRequestJobVariant2VolumeType2.Dataset,
                "model" => CreateSettingsWebhooksRequestJobVariant2VolumeType2.Model,
                "space" => CreateSettingsWebhooksRequestJobVariant2VolumeType2.Space,
                _ => null,
            };
        }
    }
}