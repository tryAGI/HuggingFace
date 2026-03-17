
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestWatchedItemType
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
    public static class RequestWatchedItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestWatchedItemType value)
        {
            return value switch
            {
                RequestWatchedItemType.Dataset => "dataset",
                RequestWatchedItemType.Model => "model",
                RequestWatchedItemType.Space => "space",
                RequestWatchedItemType.Bucket => "bucket",
                RequestWatchedItemType.Kernel => "kernel",
                RequestWatchedItemType.User => "user",
                RequestWatchedItemType.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestWatchedItemType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RequestWatchedItemType.Dataset,
                "model" => RequestWatchedItemType.Model,
                "space" => RequestWatchedItemType.Space,
                "bucket" => RequestWatchedItemType.Bucket,
                "kernel" => RequestWatchedItemType.Kernel,
                "user" => RequestWatchedItemType.User,
                "org" => RequestWatchedItemType.Org,
                _ => null,
            };
        }
    }
}