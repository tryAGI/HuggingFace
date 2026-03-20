
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType21
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
    public static class RepoType21Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType21 value)
        {
            return value switch
            {
                RepoType21.Dataset => "dataset",
                RepoType21.Model => "model",
                RepoType21.Space => "space",
                RepoType21.Bucket => "bucket",
                RepoType21.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType21? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RepoType21.Dataset,
                "model" => RepoType21.Model,
                "space" => RepoType21.Space,
                "bucket" => RepoType21.Bucket,
                "kernel" => RepoType21.Kernel,
                _ => null,
            };
        }
    }
}