
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestWatchedItemType2
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
    public static class RequestWatchedItemType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestWatchedItemType2 value)
        {
            return value switch
            {
                RequestWatchedItemType2.Dataset => "dataset",
                RequestWatchedItemType2.Model => "model",
                RequestWatchedItemType2.Space => "space",
                RequestWatchedItemType2.Bucket => "bucket",
                RequestWatchedItemType2.Kernel => "kernel",
                RequestWatchedItemType2.User => "user",
                RequestWatchedItemType2.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestWatchedItemType2? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RequestWatchedItemType2.Dataset,
                "model" => RequestWatchedItemType2.Model,
                "space" => RequestWatchedItemType2.Space,
                "bucket" => RequestWatchedItemType2.Bucket,
                "kernel" => RequestWatchedItemType2.Kernel,
                "user" => RequestWatchedItemType2.User,
                "org" => RequestWatchedItemType2.Org,
                _ => null,
            };
        }
    }
}