
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType23
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
    public static class RepoType23Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType23 value)
        {
            return value switch
            {
                RepoType23.Dataset => "dataset",
                RepoType23.Model => "model",
                RepoType23.Space => "space",
                RepoType23.Bucket => "bucket",
                RepoType23.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType23? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RepoType23.Dataset,
                "model" => RepoType23.Model,
                "space" => RepoType23.Space,
                "bucket" => RepoType23.Bucket,
                "kernel" => RepoType23.Kernel,
                _ => null,
            };
        }
    }
}