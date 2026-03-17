
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType23
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
    public static class RepoType23Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType23 value)
        {
            return value switch
            {
                RepoType23.Models => "models",
                RepoType23.Spaces => "spaces",
                RepoType23.Datasets => "datasets",
                RepoType23.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType23? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType23.Models,
                "spaces" => RepoType23.Spaces,
                "datasets" => RepoType23.Datasets,
                "kernels" => RepoType23.Kernels,
                _ => null,
            };
        }
    }
}