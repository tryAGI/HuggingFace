
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType17
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
    public static class RepoType17Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType17 value)
        {
            return value switch
            {
                RepoType17.Models => "models",
                RepoType17.Spaces => "spaces",
                RepoType17.Datasets => "datasets",
                RepoType17.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType17? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType17.Models,
                "spaces" => RepoType17.Spaces,
                "datasets" => RepoType17.Datasets,
                "kernels" => RepoType17.Kernels,
                _ => null,
            };
        }
    }
}