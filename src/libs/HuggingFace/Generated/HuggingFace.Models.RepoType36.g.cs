
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType36
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
    public static class RepoType36Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType36 value)
        {
            return value switch
            {
                RepoType36.Models => "models",
                RepoType36.Spaces => "spaces",
                RepoType36.Datasets => "datasets",
                RepoType36.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType36? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType36.Models,
                "spaces" => RepoType36.Spaces,
                "datasets" => RepoType36.Datasets,
                "kernels" => RepoType36.Kernels,
                _ => null,
            };
        }
    }
}