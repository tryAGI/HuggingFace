
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSettingsWebhooksRequestJobVariant1VolumeType2
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
    public static class CreateSettingsWebhooksRequestJobVariant1VolumeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestJobVariant1VolumeType2 value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestJobVariant1VolumeType2.Bucket => "bucket",
                CreateSettingsWebhooksRequestJobVariant1VolumeType2.Dataset => "dataset",
                CreateSettingsWebhooksRequestJobVariant1VolumeType2.Model => "model",
                CreateSettingsWebhooksRequestJobVariant1VolumeType2.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestJobVariant1VolumeType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateSettingsWebhooksRequestJobVariant1VolumeType2.Bucket,
                "dataset" => CreateSettingsWebhooksRequestJobVariant1VolumeType2.Dataset,
                "model" => CreateSettingsWebhooksRequestJobVariant1VolumeType2.Model,
                "space" => CreateSettingsWebhooksRequestJobVariant1VolumeType2.Space,
                _ => null,
            };
        }
    }
}