
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteNotificationsRepoType
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
    public static class DeleteNotificationsRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteNotificationsRepoType value)
        {
            return value switch
            {
                DeleteNotificationsRepoType.Bucket => "bucket",
                DeleteNotificationsRepoType.Dataset => "dataset",
                DeleteNotificationsRepoType.Kernel => "kernel",
                DeleteNotificationsRepoType.Model => "model",
                DeleteNotificationsRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteNotificationsRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => DeleteNotificationsRepoType.Bucket,
                "dataset" => DeleteNotificationsRepoType.Dataset,
                "kernel" => DeleteNotificationsRepoType.Kernel,
                "model" => DeleteNotificationsRepoType.Model,
                "space" => DeleteNotificationsRepoType.Space,
                _ => null,
            };
        }
    }
}