
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType20
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
    public static class RepoType20Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType20 value)
        {
            return value switch
            {
                RepoType20.Models => "models",
                RepoType20.Spaces => "spaces",
                RepoType20.Datasets => "datasets",
                RepoType20.Kernels => "kernels",
                RepoType20.Buckets => "buckets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType20? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType20.Models,
                "spaces" => RepoType20.Spaces,
                "datasets" => RepoType20.Datasets,
                "kernels" => RepoType20.Kernels,
                "buckets" => RepoType20.Buckets,
                _ => null,
            };
        }
    }
}