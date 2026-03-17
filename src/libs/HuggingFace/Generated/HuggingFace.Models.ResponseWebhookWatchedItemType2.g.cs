
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseWebhookWatchedItemType2
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
    public static class ResponseWebhookWatchedItemType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebhookWatchedItemType2 value)
        {
            return value switch
            {
                ResponseWebhookWatchedItemType2.Dataset => "dataset",
                ResponseWebhookWatchedItemType2.Model => "model",
                ResponseWebhookWatchedItemType2.Space => "space",
                ResponseWebhookWatchedItemType2.Bucket => "bucket",
                ResponseWebhookWatchedItemType2.Kernel => "kernel",
                ResponseWebhookWatchedItemType2.User => "user",
                ResponseWebhookWatchedItemType2.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebhookWatchedItemType2? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ResponseWebhookWatchedItemType2.Dataset,
                "model" => ResponseWebhookWatchedItemType2.Model,
                "space" => ResponseWebhookWatchedItemType2.Space,
                "bucket" => ResponseWebhookWatchedItemType2.Bucket,
                "kernel" => ResponseWebhookWatchedItemType2.Kernel,
                "user" => ResponseWebhookWatchedItemType2.User,
                "org" => ResponseWebhookWatchedItemType2.Org,
                _ => null,
            };
        }
    }
}