
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType29
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
    public static class RepoType29Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType29 value)
        {
            return value switch
            {
                RepoType29.Models => "models",
                RepoType29.Spaces => "spaces",
                RepoType29.Datasets => "datasets",
                RepoType29.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType29? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType29.Models,
                "spaces" => RepoType29.Spaces,
                "datasets" => RepoType29.Datasets,
                "kernels" => RepoType29.Kernels,
                _ => null,
            };
        }
    }
}