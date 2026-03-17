
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType49
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
    public static class RepoType49Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType49 value)
        {
            return value switch
            {
                RepoType49.Spaces => "spaces",
                RepoType49.Datasets => "datasets",
                RepoType49.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType49? ToEnum(string value)
        {
            return value switch
            {
                "spaces" => RepoType49.Spaces,
                "datasets" => RepoType49.Datasets,
                "kernels" => RepoType49.Kernels,
                _ => null,
            };
        }
    }
}