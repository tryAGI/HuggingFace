
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksResponseWebhookWatchedItemType
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
        Kernel,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        Space,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSettingsWebhooksResponseWebhookWatchedItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksResponseWebhookWatchedItemType value)
        {
            return value switch
            {
                CreateSettingsWebhooksResponseWebhookWatchedItemType.Bucket => "bucket",
                CreateSettingsWebhooksResponseWebhookWatchedItemType.Dataset => "dataset",
                CreateSettingsWebhooksResponseWebhookWatchedItemType.Kernel => "kernel",
                CreateSettingsWebhooksResponseWebhookWatchedItemType.Model => "model",
                CreateSettingsWebhooksResponseWebhookWatchedItemType.Org => "org",
                CreateSettingsWebhooksResponseWebhookWatchedItemType.Space => "space",
                CreateSettingsWebhooksResponseWebhookWatchedItemType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksResponseWebhookWatchedItemType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateSettingsWebhooksResponseWebhookWatchedItemType.Bucket,
                "dataset" => CreateSettingsWebhooksResponseWebhookWatchedItemType.Dataset,
                "kernel" => CreateSettingsWebhooksResponseWebhookWatchedItemType.Kernel,
                "model" => CreateSettingsWebhooksResponseWebhookWatchedItemType.Model,
                "org" => CreateSettingsWebhooksResponseWebhookWatchedItemType.Org,
                "space" => CreateSettingsWebhooksResponseWebhookWatchedItemType.Space,
                "user" => CreateSettingsWebhooksResponseWebhookWatchedItemType.User,
                _ => null,
            };
        }
    }
}