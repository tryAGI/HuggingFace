
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType33
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepoType33Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType33 value)
        {
            return value switch
            {
                RepoType33.Models => "models",
                RepoType33.Spaces => "spaces",
                RepoType33.Datasets => "datasets",
                RepoType33.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType33? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType33.Models,
                "spaces" => RepoType33.Spaces,
                "datasets" => RepoType33.Datasets,
                "kernels" => RepoType33.Kernels,
                _ => null,
            };
        }
    }
}