
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType6
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
    public static class RepoType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType6 value)
        {
            return value switch
            {
                RepoType6.Models => "models",
                RepoType6.Spaces => "spaces",
                RepoType6.Datasets => "datasets",
                RepoType6.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType6? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType6.Models,
                "spaces" => RepoType6.Spaces,
                "datasets" => RepoType6.Datasets,
                "kernels" => RepoType6.Kernels,
                _ => null,
            };
        }
    }
}