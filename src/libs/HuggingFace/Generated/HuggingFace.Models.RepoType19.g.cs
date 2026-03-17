
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType19
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
    public static class RepoType19Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType19 value)
        {
            return value switch
            {
                RepoType19.Models => "models",
                RepoType19.Spaces => "spaces",
                RepoType19.Datasets => "datasets",
                RepoType19.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType19? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType19.Models,
                "spaces" => RepoType19.Spaces,
                "datasets" => RepoType19.Datasets,
                "kernels" => RepoType19.Kernels,
                _ => null,
            };
        }
    }
}