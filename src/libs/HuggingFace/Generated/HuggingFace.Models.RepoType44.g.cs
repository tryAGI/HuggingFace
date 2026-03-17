
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType44
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
    public static class RepoType44Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType44 value)
        {
            return value switch
            {
                RepoType44.Dataset => "dataset",
                RepoType44.Model => "model",
                RepoType44.Space => "space",
                RepoType44.Bucket => "bucket",
                RepoType44.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType44? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RepoType44.Dataset,
                "model" => RepoType44.Model,
                "space" => RepoType44.Space,
                "bucket" => RepoType44.Bucket,
                "kernel" => RepoType44.Kernel,
                _ => null,
            };
        }
    }
}