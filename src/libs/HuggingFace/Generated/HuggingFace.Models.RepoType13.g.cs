
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType13
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
    public static class RepoType13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType13 value)
        {
            return value switch
            {
                RepoType13.Models => "models",
                RepoType13.Spaces => "spaces",
                RepoType13.Datasets => "datasets",
                RepoType13.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType13? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType13.Models,
                "spaces" => RepoType13.Spaces,
                "datasets" => RepoType13.Datasets,
                "kernels" => RepoType13.Kernels,
                _ => null,
            };
        }
    }
}