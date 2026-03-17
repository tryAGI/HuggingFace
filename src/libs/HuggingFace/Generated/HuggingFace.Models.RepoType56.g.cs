
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType56
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
    public static class RepoType56Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType56 value)
        {
            return value switch
            {
                RepoType56.Models => "models",
                RepoType56.Spaces => "spaces",
                RepoType56.Datasets => "datasets",
                RepoType56.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType56? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType56.Models,
                "spaces" => RepoType56.Spaces,
                "datasets" => RepoType56.Datasets,
                "kernels" => RepoType56.Kernels,
                _ => null,
            };
        }
    }
}