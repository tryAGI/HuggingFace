
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksRequestJobVolumeType
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
    public static class CreateSettingsWebhooksRequestJobVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestJobVolumeType value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestJobVolumeType.Bucket => "bucket",
                CreateSettingsWebhooksRequestJobVolumeType.Dataset => "dataset",
                CreateSettingsWebhooksRequestJobVolumeType.Model => "model",
                CreateSettingsWebhooksRequestJobVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestJobVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateSettingsWebhooksRequestJobVolumeType.Bucket,
                "dataset" => CreateSettingsWebhooksRequestJobVolumeType.Dataset,
                "model" => CreateSettingsWebhooksRequestJobVolumeType.Model,
                "space" => CreateSettingsWebhooksRequestJobVolumeType.Space,
                _ => null,
            };
        }
    }
}