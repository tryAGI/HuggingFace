
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType5
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
    public static class RepoType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType5 value)
        {
            return value switch
            {
                RepoType5.Models => "models",
                RepoType5.Spaces => "spaces",
                RepoType5.Datasets => "datasets",
                RepoType5.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType5? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType5.Models,
                "spaces" => RepoType5.Spaces,
                "datasets" => RepoType5.Datasets,
                "kernels" => RepoType5.Kernels,
                _ => null,
            };
        }
    }
}