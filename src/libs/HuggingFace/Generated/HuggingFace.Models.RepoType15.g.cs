
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType15
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
    public static class RepoType15Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType15 value)
        {
            return value switch
            {
                RepoType15.Models => "models",
                RepoType15.Spaces => "spaces",
                RepoType15.Datasets => "datasets",
                RepoType15.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType15? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType15.Models,
                "spaces" => RepoType15.Spaces,
                "datasets" => RepoType15.Datasets,
                "kernels" => RepoType15.Kernels,
                _ => null,
            };
        }
    }
}