
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType37
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
    public static class RepoType37Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType37 value)
        {
            return value switch
            {
                RepoType37.Models => "models",
                RepoType37.Spaces => "spaces",
                RepoType37.Datasets => "datasets",
                RepoType37.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType37? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType37.Models,
                "spaces" => RepoType37.Spaces,
                "datasets" => RepoType37.Datasets,
                "kernels" => RepoType37.Kernels,
                _ => null,
            };
        }
    }
}