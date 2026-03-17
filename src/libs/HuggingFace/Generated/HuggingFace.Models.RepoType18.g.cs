
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType18
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
    public static class RepoType18Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType18 value)
        {
            return value switch
            {
                RepoType18.Models => "models",
                RepoType18.Spaces => "spaces",
                RepoType18.Datasets => "datasets",
                RepoType18.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType18? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType18.Models,
                "spaces" => RepoType18.Spaces,
                "datasets" => RepoType18.Datasets,
                "kernels" => RepoType18.Kernels,
                _ => null,
            };
        }
    }
}