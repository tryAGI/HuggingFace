
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksResponseWebhookWatchedItemType3
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
    public static class CreateSettingsWebhooksResponseWebhookWatchedItemType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksResponseWebhookWatchedItemType3 value)
        {
            return value switch
            {
                CreateSettingsWebhooksResponseWebhookWatchedItemType3.Bucket => "bucket",
                CreateSettingsWebhooksResponseWebhookWatchedItemType3.Dataset => "dataset",
                CreateSettingsWebhooksResponseWebhookWatchedItemType3.Kernel => "kernel",
                CreateSettingsWebhooksResponseWebhookWatchedItemType3.Model => "model",
                CreateSettingsWebhooksResponseWebhookWatchedItemType3.Org => "org",
                CreateSettingsWebhooksResponseWebhookWatchedItemType3.Space => "space",
                CreateSettingsWebhooksResponseWebhookWatchedItemType3.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksResponseWebhookWatchedItemType3? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateSettingsWebhooksResponseWebhookWatchedItemType3.Bucket,
                "dataset" => CreateSettingsWebhooksResponseWebhookWatchedItemType3.Dataset,
                "kernel" => CreateSettingsWebhooksResponseWebhookWatchedItemType3.Kernel,
                "model" => CreateSettingsWebhooksResponseWebhookWatchedItemType3.Model,
                "org" => CreateSettingsWebhooksResponseWebhookWatchedItemType3.Org,
                "space" => CreateSettingsWebhooksResponseWebhookWatchedItemType3.Space,
                "user" => CreateSettingsWebhooksResponseWebhookWatchedItemType3.User,
                _ => null,
            };
        }
    }
}