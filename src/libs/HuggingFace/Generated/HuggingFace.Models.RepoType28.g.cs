
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType28
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
    public static class RepoType28Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType28 value)
        {
            return value switch
            {
                RepoType28.Models => "models",
                RepoType28.Spaces => "spaces",
                RepoType28.Datasets => "datasets",
                RepoType28.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType28? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType28.Models,
                "spaces" => RepoType28.Spaces,
                "datasets" => RepoType28.Datasets,
                "kernels" => RepoType28.Kernels,
                _ => null,
            };
        }
    }
}