
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseWebhookWatchedItemType4
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
    public static class ResponseWebhookWatchedItemType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebhookWatchedItemType4 value)
        {
            return value switch
            {
                ResponseWebhookWatchedItemType4.Dataset => "dataset",
                ResponseWebhookWatchedItemType4.Model => "model",
                ResponseWebhookWatchedItemType4.Space => "space",
                ResponseWebhookWatchedItemType4.Bucket => "bucket",
                ResponseWebhookWatchedItemType4.Kernel => "kernel",
                ResponseWebhookWatchedItemType4.User => "user",
                ResponseWebhookWatchedItemType4.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebhookWatchedItemType4? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ResponseWebhookWatchedItemType4.Dataset,
                "model" => ResponseWebhookWatchedItemType4.Model,
                "space" => ResponseWebhookWatchedItemType4.Space,
                "bucket" => ResponseWebhookWatchedItemType4.Bucket,
                "kernel" => ResponseWebhookWatchedItemType4.Kernel,
                "user" => ResponseWebhookWatchedItemType4.User,
                "org" => ResponseWebhookWatchedItemType4.Org,
                _ => null,
            };
        }
    }
}