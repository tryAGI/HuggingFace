
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType3
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
    public static class RepoType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType3 value)
        {
            return value switch
            {
                RepoType3.Dataset => "dataset",
                RepoType3.Model => "model",
                RepoType3.Space => "space",
                RepoType3.Bucket => "bucket",
                RepoType3.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType3? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RepoType3.Dataset,
                "model" => RepoType3.Model,
                "space" => RepoType3.Space,
                "bucket" => RepoType3.Bucket,
                "kernel" => RepoType3.Kernel,
                _ => null,
            };
        }
    }
}