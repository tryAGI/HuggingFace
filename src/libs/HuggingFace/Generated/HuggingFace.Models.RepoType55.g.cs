
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType55
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
    public static class RepoType55Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType55 value)
        {
            return value switch
            {
                RepoType55.Models => "models",
                RepoType55.Spaces => "spaces",
                RepoType55.Datasets => "datasets",
                RepoType55.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType55? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType55.Models,
                "spaces" => RepoType55.Spaces,
                "datasets" => RepoType55.Datasets,
                "kernels" => RepoType55.Kernels,
                _ => null,
            };
        }
    }
}