
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateNotificationsMarkAsReadRepoType
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
    public static class CreateNotificationsMarkAsReadRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateNotificationsMarkAsReadRepoType value)
        {
            return value switch
            {
                CreateNotificationsMarkAsReadRepoType.Bucket => "bucket",
                CreateNotificationsMarkAsReadRepoType.Dataset => "dataset",
                CreateNotificationsMarkAsReadRepoType.Kernel => "kernel",
                CreateNotificationsMarkAsReadRepoType.Model => "model",
                CreateNotificationsMarkAsReadRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateNotificationsMarkAsReadRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateNotificationsMarkAsReadRepoType.Bucket,
                "dataset" => CreateNotificationsMarkAsReadRepoType.Dataset,
                "kernel" => CreateNotificationsMarkAsReadRepoType.Kernel,
                "model" => CreateNotificationsMarkAsReadRepoType.Model,
                "space" => CreateNotificationsMarkAsReadRepoType.Space,
                _ => null,
            };
        }
    }
}