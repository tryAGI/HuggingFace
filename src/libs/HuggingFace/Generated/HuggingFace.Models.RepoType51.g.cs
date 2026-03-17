
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType51
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
    public static class RepoType51Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType51 value)
        {
            return value switch
            {
                RepoType51.Spaces => "spaces",
                RepoType51.Datasets => "datasets",
                RepoType51.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType51? ToEnum(string value)
        {
            return value switch
            {
                "spaces" => RepoType51.Spaces,
                "datasets" => RepoType51.Datasets,
                "kernels" => RepoType51.Kernels,
                _ => null,
            };
        }
    }
}