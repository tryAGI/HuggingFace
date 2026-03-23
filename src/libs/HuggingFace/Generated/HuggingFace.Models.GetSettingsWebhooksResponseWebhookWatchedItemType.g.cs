
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsWebhooksResponseWebhookWatchedItemType
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
    public static class GetSettingsWebhooksResponseWebhookWatchedItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsWebhooksResponseWebhookWatchedItemType value)
        {
            return value switch
            {
                GetSettingsWebhooksResponseWebhookWatchedItemType.Bucket => "bucket",
                GetSettingsWebhooksResponseWebhookWatchedItemType.Dataset => "dataset",
                GetSettingsWebhooksResponseWebhookWatchedItemType.Kernel => "kernel",
                GetSettingsWebhooksResponseWebhookWatchedItemType.Model => "model",
                GetSettingsWebhooksResponseWebhookWatchedItemType.Org => "org",
                GetSettingsWebhooksResponseWebhookWatchedItemType.Space => "space",
                GetSettingsWebhooksResponseWebhookWatchedItemType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsWebhooksResponseWebhookWatchedItemType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetSettingsWebhooksResponseWebhookWatchedItemType.Bucket,
                "dataset" => GetSettingsWebhooksResponseWebhookWatchedItemType.Dataset,
                "kernel" => GetSettingsWebhooksResponseWebhookWatchedItemType.Kernel,
                "model" => GetSettingsWebhooksResponseWebhookWatchedItemType.Model,
                "org" => GetSettingsWebhooksResponseWebhookWatchedItemType.Org,
                "space" => GetSettingsWebhooksResponseWebhookWatchedItemType.Space,
                "user" => GetSettingsWebhooksResponseWebhookWatchedItemType.User,
                _ => null,
            };
        }
    }
}