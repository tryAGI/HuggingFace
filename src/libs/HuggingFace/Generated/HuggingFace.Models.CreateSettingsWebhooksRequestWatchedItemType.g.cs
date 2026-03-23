
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksRequestWatchedItemType
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
    public static class CreateSettingsWebhooksRequestWatchedItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestWatchedItemType value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestWatchedItemType.Bucket => "bucket",
                CreateSettingsWebhooksRequestWatchedItemType.Dataset => "dataset",
                CreateSettingsWebhooksRequestWatchedItemType.Kernel => "kernel",
                CreateSettingsWebhooksRequestWatchedItemType.Model => "model",
                CreateSettingsWebhooksRequestWatchedItemType.Org => "org",
                CreateSettingsWebhooksRequestWatchedItemType.Space => "space",
                CreateSettingsWebhooksRequestWatchedItemType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestWatchedItemType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateSettingsWebhooksRequestWatchedItemType.Bucket,
                "dataset" => CreateSettingsWebhooksRequestWatchedItemType.Dataset,
                "kernel" => CreateSettingsWebhooksRequestWatchedItemType.Kernel,
                "model" => CreateSettingsWebhooksRequestWatchedItemType.Model,
                "org" => CreateSettingsWebhooksRequestWatchedItemType.Org,
                "space" => CreateSettingsWebhooksRequestWatchedItemType.Space,
                "user" => CreateSettingsWebhooksRequestWatchedItemType.User,
                _ => null,
            };
        }
    }
}