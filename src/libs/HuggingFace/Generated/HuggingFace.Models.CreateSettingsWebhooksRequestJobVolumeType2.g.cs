
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksRequestJobVolumeType2
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
    public static class CreateSettingsWebhooksRequestJobVolumeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestJobVolumeType2 value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestJobVolumeType2.Bucket => "bucket",
                CreateSettingsWebhooksRequestJobVolumeType2.Dataset => "dataset",
                CreateSettingsWebhooksRequestJobVolumeType2.Model => "model",
                CreateSettingsWebhooksRequestJobVolumeType2.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestJobVolumeType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateSettingsWebhooksRequestJobVolumeType2.Bucket,
                "dataset" => CreateSettingsWebhooksRequestJobVolumeType2.Dataset,
                "model" => CreateSettingsWebhooksRequestJobVolumeType2.Model,
                "space" => CreateSettingsWebhooksRequestJobVolumeType2.Space,
                _ => null,
            };
        }
    }
}