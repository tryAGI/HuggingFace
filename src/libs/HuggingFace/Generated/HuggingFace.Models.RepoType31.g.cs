
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType31
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
    public static class RepoType31Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType31 value)
        {
            return value switch
            {
                RepoType31.Models => "models",
                RepoType31.Spaces => "spaces",
                RepoType31.Datasets => "datasets",
                RepoType31.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType31? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType31.Models,
                "spaces" => RepoType31.Spaces,
                "datasets" => RepoType31.Datasets,
                "kernels" => RepoType31.Kernels,
                _ => null,
            };
        }
    }
}