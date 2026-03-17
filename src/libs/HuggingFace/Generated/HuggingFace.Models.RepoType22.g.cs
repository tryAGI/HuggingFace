
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType22
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
    public static class RepoType22Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType22 value)
        {
            return value switch
            {
                RepoType22.Models => "models",
                RepoType22.Spaces => "spaces",
                RepoType22.Datasets => "datasets",
                RepoType22.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType22? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType22.Models,
                "spaces" => RepoType22.Spaces,
                "datasets" => RepoType22.Datasets,
                "kernels" => RepoType22.Kernels,
                _ => null,
            };
        }
    }
}