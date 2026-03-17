
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType42
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
    public static class RepoType42Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType42 value)
        {
            return value switch
            {
                RepoType42.Dataset => "dataset",
                RepoType42.Model => "model",
                RepoType42.Space => "space",
                RepoType42.Bucket => "bucket",
                RepoType42.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType42? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RepoType42.Dataset,
                "model" => RepoType42.Model,
                "space" => RepoType42.Space,
                "bucket" => RepoType42.Bucket,
                "kernel" => RepoType42.Kernel,
                _ => null,
            };
        }
    }
}