
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType14
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
    public static class RepoType14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType14 value)
        {
            return value switch
            {
                RepoType14.Models => "models",
                RepoType14.Spaces => "spaces",
                RepoType14.Datasets => "datasets",
                RepoType14.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType14? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType14.Models,
                "spaces" => RepoType14.Spaces,
                "datasets" => RepoType14.Datasets,
                "kernels" => RepoType14.Kernels,
                _ => null,
            };
        }
    }
}