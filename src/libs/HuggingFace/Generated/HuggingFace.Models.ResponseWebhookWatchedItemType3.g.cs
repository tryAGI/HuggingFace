
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseWebhookWatchedItemType3
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
    public static class ResponseWebhookWatchedItemType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebhookWatchedItemType3 value)
        {
            return value switch
            {
                ResponseWebhookWatchedItemType3.Dataset => "dataset",
                ResponseWebhookWatchedItemType3.Model => "model",
                ResponseWebhookWatchedItemType3.Space => "space",
                ResponseWebhookWatchedItemType3.Bucket => "bucket",
                ResponseWebhookWatchedItemType3.Kernel => "kernel",
                ResponseWebhookWatchedItemType3.User => "user",
                ResponseWebhookWatchedItemType3.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebhookWatchedItemType3? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ResponseWebhookWatchedItemType3.Dataset,
                "model" => ResponseWebhookWatchedItemType3.Model,
                "space" => ResponseWebhookWatchedItemType3.Space,
                "bucket" => ResponseWebhookWatchedItemType3.Bucket,
                "kernel" => ResponseWebhookWatchedItemType3.Kernel,
                "user" => ResponseWebhookWatchedItemType3.User,
                "org" => ResponseWebhookWatchedItemType3.Org,
                _ => null,
            };
        }
    }
}