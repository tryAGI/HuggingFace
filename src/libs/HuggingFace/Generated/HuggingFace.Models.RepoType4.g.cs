
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType4
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
    public static class RepoType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType4 value)
        {
            return value switch
            {
                RepoType4.Dataset => "dataset",
                RepoType4.Model => "model",
                RepoType4.Space => "space",
                RepoType4.Bucket => "bucket",
                RepoType4.Kernel => "kernel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType4? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => RepoType4.Dataset,
                "model" => RepoType4.Model,
                "space" => RepoType4.Space,
                "bucket" => RepoType4.Bucket,
                "kernel" => RepoType4.Kernel,
                _ => null,
            };
        }
    }
}