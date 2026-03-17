
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoIdType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepoIdTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoIdType value)
        {
            return value switch
            {
                RepoIdType.Dataset => "dataset",
                RepoIdType.Model => "model",
                RepoIdType.Space => "space",
                RepoIdType.Bucket => "bucket",
                RepoIdType.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoIdType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RepoIdType.Dataset,
                "model" => RepoIdType.Model,
                "space" => RepoIdType.Space,
                "bucket" => RepoIdType.Bucket,
                "kernel" => RepoIdType.Kernel,
                _ => null,
            };
        }
    }
}