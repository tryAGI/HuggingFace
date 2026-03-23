
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetNotificationsRepoType
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
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetNotificationsRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetNotificationsRepoType value)
        {
            return value switch
            {
                GetNotificationsRepoType.Bucket => "bucket",
                GetNotificationsRepoType.Dataset => "dataset",
                GetNotificationsRepoType.Kernel => "kernel",
                GetNotificationsRepoType.Model => "model",
                GetNotificationsRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetNotificationsRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetNotificationsRepoType.Bucket,
                "dataset" => GetNotificationsRepoType.Dataset,
                "kernel" => GetNotificationsRepoType.Kernel,
                "model" => GetNotificationsRepoType.Model,
                "space" => GetNotificationsRepoType.Space,
                _ => null,
            };
        }
    }
}