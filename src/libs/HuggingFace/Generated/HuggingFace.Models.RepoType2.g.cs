
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType2
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
    public static class RepoType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType2 value)
        {
            return value switch
            {
                RepoType2.Dataset => "dataset",
                RepoType2.Model => "model",
                RepoType2.Space => "space",
                RepoType2.Bucket => "bucket",
                RepoType2.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType2? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RepoType2.Dataset,
                "model" => RepoType2.Model,
                "space" => RepoType2.Space,
                "bucket" => RepoType2.Bucket,
                "kernel" => RepoType2.Kernel,
                _ => null,
            };
        }
    }
}