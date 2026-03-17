
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemWatchedItemType
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
    public static class ResponseItemWatchedItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemWatchedItemType value)
        {
            return value switch
            {
                ResponseItemWatchedItemType.Dataset => "dataset",
                ResponseItemWatchedItemType.Model => "model",
                ResponseItemWatchedItemType.Space => "space",
                ResponseItemWatchedItemType.Bucket => "bucket",
                ResponseItemWatchedItemType.Kernel => "kernel",
                ResponseItemWatchedItemType.User => "user",
                ResponseItemWatchedItemType.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemWatchedItemType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ResponseItemWatchedItemType.Dataset,
                "model" => ResponseItemWatchedItemType.Model,
                "space" => ResponseItemWatchedItemType.Space,
                "bucket" => ResponseItemWatchedItemType.Bucket,
                "kernel" => ResponseItemWatchedItemType.Kernel,
                "user" => ResponseItemWatchedItemType.User,
                "org" => ResponseItemWatchedItemType.Org,
                _ => null,
            };
        }
    }
}