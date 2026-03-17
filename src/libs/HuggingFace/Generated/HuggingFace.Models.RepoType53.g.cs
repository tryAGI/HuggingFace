
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType53
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
    public static class RepoType53Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType53 value)
        {
            return value switch
            {
                RepoType53.Models => "models",
                RepoType53.Spaces => "spaces",
                RepoType53.Datasets => "datasets",
                RepoType53.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType53? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType53.Models,
                "spaces" => RepoType53.Spaces,
                "datasets" => RepoType53.Datasets,
                "kernels" => RepoType53.Kernels,
                _ => null,
            };
        }
    }
}