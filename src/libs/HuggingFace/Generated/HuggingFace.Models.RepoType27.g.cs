
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType27
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
    public static class RepoType27Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType27 value)
        {
            return value switch
            {
                RepoType27.Models => "models",
                RepoType27.Spaces => "spaces",
                RepoType27.Datasets => "datasets",
                RepoType27.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType27? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType27.Models,
                "spaces" => RepoType27.Spaces,
                "datasets" => RepoType27.Datasets,
                "kernels" => RepoType27.Kernels,
                _ => null,
            };
        }
    }
}