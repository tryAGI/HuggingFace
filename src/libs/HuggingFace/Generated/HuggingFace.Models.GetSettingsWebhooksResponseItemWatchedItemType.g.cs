
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsWebhooksResponseItemWatchedItemType
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
    public static class GetSettingsWebhooksResponseItemWatchedItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsWebhooksResponseItemWatchedItemType value)
        {
            return value switch
            {
                GetSettingsWebhooksResponseItemWatchedItemType.Bucket => "bucket",
                GetSettingsWebhooksResponseItemWatchedItemType.Dataset => "dataset",
                GetSettingsWebhooksResponseItemWatchedItemType.Kernel => "kernel",
                GetSettingsWebhooksResponseItemWatchedItemType.Model => "model",
                GetSettingsWebhooksResponseItemWatchedItemType.Org => "org",
                GetSettingsWebhooksResponseItemWatchedItemType.Space => "space",
                GetSettingsWebhooksResponseItemWatchedItemType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsWebhooksResponseItemWatchedItemType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetSettingsWebhooksResponseItemWatchedItemType.Bucket,
                "dataset" => GetSettingsWebhooksResponseItemWatchedItemType.Dataset,
                "kernel" => GetSettingsWebhooksResponseItemWatchedItemType.Kernel,
                "model" => GetSettingsWebhooksResponseItemWatchedItemType.Model,
                "org" => GetSettingsWebhooksResponseItemWatchedItemType.Org,
                "space" => GetSettingsWebhooksResponseItemWatchedItemType.Space,
                "user" => GetSettingsWebhooksResponseItemWatchedItemType.User,
                _ => null,
            };
        }
    }
}