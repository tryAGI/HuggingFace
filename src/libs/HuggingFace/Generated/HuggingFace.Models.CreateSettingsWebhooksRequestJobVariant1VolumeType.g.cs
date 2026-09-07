
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSettingsWebhooksRequestJobVariant1VolumeType
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
    public static class CreateSettingsWebhooksRequestJobVariant1VolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestJobVariant1VolumeType value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestJobVariant1VolumeType.Bucket => "bucket",
                CreateSettingsWebhooksRequestJobVariant1VolumeType.Dataset => "dataset",
                CreateSettingsWebhooksRequestJobVariant1VolumeType.Model => "model",
                CreateSettingsWebhooksRequestJobVariant1VolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestJobVariant1VolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateSettingsWebhooksRequestJobVariant1VolumeType.Bucket,
                "dataset" => CreateSettingsWebhooksRequestJobVariant1VolumeType.Dataset,
                "model" => CreateSettingsWebhooksRequestJobVariant1VolumeType.Model,
                "space" => CreateSettingsWebhooksRequestJobVariant1VolumeType.Space,
                _ => null,
            };
        }
    }
}