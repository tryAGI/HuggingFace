
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksResponseWebhookWatchedItemType2
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
    public static class CreateSettingsWebhooksResponseWebhookWatchedItemType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksResponseWebhookWatchedItemType2 value)
        {
            return value switch
            {
                CreateSettingsWebhooksResponseWebhookWatchedItemType2.Bucket => "bucket",
                CreateSettingsWebhooksResponseWebhookWatchedItemType2.Dataset => "dataset",
                CreateSettingsWebhooksResponseWebhookWatchedItemType2.Kernel => "kernel",
                CreateSettingsWebhooksResponseWebhookWatchedItemType2.Model => "model",
                CreateSettingsWebhooksResponseWebhookWatchedItemType2.Org => "org",
                CreateSettingsWebhooksResponseWebhookWatchedItemType2.Space => "space",
                CreateSettingsWebhooksResponseWebhookWatchedItemType2.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksResponseWebhookWatchedItemType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateSettingsWebhooksResponseWebhookWatchedItemType2.Bucket,
                "dataset" => CreateSettingsWebhooksResponseWebhookWatchedItemType2.Dataset,
                "kernel" => CreateSettingsWebhooksResponseWebhookWatchedItemType2.Kernel,
                "model" => CreateSettingsWebhooksResponseWebhookWatchedItemType2.Model,
                "org" => CreateSettingsWebhooksResponseWebhookWatchedItemType2.Org,
                "space" => CreateSettingsWebhooksResponseWebhookWatchedItemType2.Space,
                "user" => CreateSettingsWebhooksResponseWebhookWatchedItemType2.User,
                _ => null,
            };
        }
    }
}