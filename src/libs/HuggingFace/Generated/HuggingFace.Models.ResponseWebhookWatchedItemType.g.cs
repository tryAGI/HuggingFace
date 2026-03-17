
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseWebhookWatchedItemType
    {
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
        /// <summary>
        /// 
        /// </summary>
        Bucket,
        /// <summary>
        /// 
        /// </summary>
        Kernel,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Org,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseWebhookWatchedItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebhookWatchedItemType value)
        {
            return value switch
            {
                ResponseWebhookWatchedItemType.Dataset => "dataset",
                ResponseWebhookWatchedItemType.Model => "model",
                ResponseWebhookWatchedItemType.Space => "space",
                ResponseWebhookWatchedItemType.Bucket => "bucket",
                ResponseWebhookWatchedItemType.Kernel => "kernel",
                ResponseWebhookWatchedItemType.User => "user",
                ResponseWebhookWatchedItemType.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebhookWatchedItemType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ResponseWebhookWatchedItemType.Dataset,
                "model" => ResponseWebhookWatchedItemType.Model,
                "space" => ResponseWebhookWatchedItemType.Space,
                "bucket" => ResponseWebhookWatchedItemType.Bucket,
                "kernel" => ResponseWebhookWatchedItemType.Kernel,
                "user" => ResponseWebhookWatchedItemType.User,
                "org" => ResponseWebhookWatchedItemType.Org,
                _ => null,
            };
        }
    }
}