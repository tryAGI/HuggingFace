
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType7
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
    public static class RepoType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType7 value)
        {
            return value switch
            {
                RepoType7.Models => "models",
                RepoType7.Spaces => "spaces",
                RepoType7.Datasets => "datasets",
                RepoType7.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType7? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType7.Models,
                "spaces" => RepoType7.Spaces,
                "datasets" => RepoType7.Datasets,
                "kernels" => RepoType7.Kernels,
                _ => null,
            };
        }
    }
}