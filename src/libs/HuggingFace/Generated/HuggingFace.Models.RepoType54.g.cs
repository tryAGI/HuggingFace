
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType54
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
    public static class RepoType54Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType54 value)
        {
            return value switch
            {
                RepoType54.Models => "models",
                RepoType54.Spaces => "spaces",
                RepoType54.Datasets => "datasets",
                RepoType54.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType54? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType54.Models,
                "spaces" => RepoType54.Spaces,
                "datasets" => RepoType54.Datasets,
                "kernels" => RepoType54.Kernels,
                _ => null,
            };
        }
    }
}