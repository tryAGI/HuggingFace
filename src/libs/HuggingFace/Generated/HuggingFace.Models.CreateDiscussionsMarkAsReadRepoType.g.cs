
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsMarkAsReadRepoType
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
    public static class CreateDiscussionsMarkAsReadRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsMarkAsReadRepoType value)
        {
            return value switch
            {
                CreateDiscussionsMarkAsReadRepoType.Bucket => "bucket",
                CreateDiscussionsMarkAsReadRepoType.Dataset => "dataset",
                CreateDiscussionsMarkAsReadRepoType.Kernel => "kernel",
                CreateDiscussionsMarkAsReadRepoType.Model => "model",
                CreateDiscussionsMarkAsReadRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsMarkAsReadRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateDiscussionsMarkAsReadRepoType.Bucket,
                "dataset" => CreateDiscussionsMarkAsReadRepoType.Dataset,
                "kernel" => CreateDiscussionsMarkAsReadRepoType.Kernel,
                "model" => CreateDiscussionsMarkAsReadRepoType.Model,
                "space" => CreateDiscussionsMarkAsReadRepoType.Space,
                _ => null,
            };
        }
    }
}