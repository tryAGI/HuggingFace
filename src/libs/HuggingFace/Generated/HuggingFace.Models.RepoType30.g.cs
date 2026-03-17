
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType30
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
    public static class RepoType30Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType30 value)
        {
            return value switch
            {
                RepoType30.Models => "models",
                RepoType30.Spaces => "spaces",
                RepoType30.Datasets => "datasets",
                RepoType30.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType30? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType30.Models,
                "spaces" => RepoType30.Spaces,
                "datasets" => RepoType30.Datasets,
                "kernels" => RepoType30.Kernels,
                _ => null,
            };
        }
    }
}