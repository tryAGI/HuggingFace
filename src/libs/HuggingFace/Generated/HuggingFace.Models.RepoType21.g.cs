
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
        Models,
        /// <summary>
        /// 
        /// </summary>
        Spaces,
        /// <summary>
        /// 
        /// </summary>
        Datasets,
        /// <summary>
        /// 
        /// </summary>
        Kernels,
        /// <summary>
        /// 
        /// </summary>
        Buckets,
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
                RepoType21.Models => "models",
                RepoType21.Spaces => "spaces",
                RepoType21.Datasets => "datasets",
                RepoType21.Kernels => "kernels",
                RepoType21.Buckets => "buckets",
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
                "models" => RepoType21.Models,
                "spaces" => RepoType21.Spaces,
                "datasets" => RepoType21.Datasets,
                "kernels" => RepoType21.Kernels,
                "buckets" => RepoType21.Buckets,
                _ => null,
            };
        }
    }
}