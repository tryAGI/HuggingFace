
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
    public static class RepoIdTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoIdType value)
        {
            return value switch
            {
                RepoIdType.Bucket => "bucket",
                RepoIdType.Dataset => "dataset",
                RepoIdType.Kernel => "kernel",
                RepoIdType.Model => "model",
                RepoIdType.Space => "space",
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
                "bucket" => RepoIdType.Bucket,
                "dataset" => RepoIdType.Dataset,
                "kernel" => RepoIdType.Kernel,
                "model" => RepoIdType.Model,
                "space" => RepoIdType.Space,
                _ => null,
            };
        }
    }
}