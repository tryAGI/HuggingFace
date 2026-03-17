
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType40
    {
        /// <summary>
        /// 
        /// </summary>
        Spaces,
        /// <summary>
        /// 
        /// </summary>
        Models,
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
    public static class RepoType40Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType40 value)
        {
            return value switch
            {
                RepoType40.Spaces => "spaces",
                RepoType40.Models => "models",
                RepoType40.Datasets => "datasets",
                RepoType40.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType40? ToEnum(string value)
        {
            return value switch
            {
                "spaces" => RepoType40.Spaces,
                "models" => RepoType40.Models,
                "datasets" => RepoType40.Datasets,
                "kernels" => RepoType40.Kernels,
                _ => null,
            };
        }
    }
}