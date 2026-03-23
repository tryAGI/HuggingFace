
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksRequestWatchedItemType2
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
    public static class CreateSettingsWebhooksRequestWatchedItemType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestWatchedItemType2 value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestWatchedItemType2.Bucket => "bucket",
                CreateSettingsWebhooksRequestWatchedItemType2.Dataset => "dataset",
                CreateSettingsWebhooksRequestWatchedItemType2.Kernel => "kernel",
                CreateSettingsWebhooksRequestWatchedItemType2.Model => "model",
                CreateSettingsWebhooksRequestWatchedItemType2.Org => "org",
                CreateSettingsWebhooksRequestWatchedItemType2.Space => "space",
                CreateSettingsWebhooksRequestWatchedItemType2.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestWatchedItemType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateSettingsWebhooksRequestWatchedItemType2.Bucket,
                "dataset" => CreateSettingsWebhooksRequestWatchedItemType2.Dataset,
                "kernel" => CreateSettingsWebhooksRequestWatchedItemType2.Kernel,
                "model" => CreateSettingsWebhooksRequestWatchedItemType2.Model,
                "org" => CreateSettingsWebhooksRequestWatchedItemType2.Org,
                "space" => CreateSettingsWebhooksRequestWatchedItemType2.Space,
                "user" => CreateSettingsWebhooksRequestWatchedItemType2.User,
                _ => null,
            };
        }
    }
}