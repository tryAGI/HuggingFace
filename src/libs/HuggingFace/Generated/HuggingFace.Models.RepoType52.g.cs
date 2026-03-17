
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType52
    {
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
    public static class RepoType52Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType52 value)
        {
            return value switch
            {
                RepoType52.Spaces => "spaces",
                RepoType52.Datasets => "datasets",
                RepoType52.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType52? ToEnum(string value)
        {
            return value switch
            {
                "spaces" => RepoType52.Spaces,
                "datasets" => RepoType52.Datasets,
                "kernels" => RepoType52.Kernels,
                _ => null,
            };
        }
    }
}