
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType32
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
    public static class RepoType32Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType32 value)
        {
            return value switch
            {
                RepoType32.Models => "models",
                RepoType32.Spaces => "spaces",
                RepoType32.Datasets => "datasets",
                RepoType32.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType32? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType32.Models,
                "spaces" => RepoType32.Spaces,
                "datasets" => RepoType32.Datasets,
                "kernels" => RepoType32.Kernels,
                _ => null,
            };
        }
    }
}