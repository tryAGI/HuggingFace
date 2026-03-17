
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType9
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
    public static class RepoType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType9 value)
        {
            return value switch
            {
                RepoType9.Models => "models",
                RepoType9.Spaces => "spaces",
                RepoType9.Datasets => "datasets",
                RepoType9.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType9? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType9.Models,
                "spaces" => RepoType9.Spaces,
                "datasets" => RepoType9.Datasets,
                "kernels" => RepoType9.Kernels,
                _ => null,
            };
        }
    }
}