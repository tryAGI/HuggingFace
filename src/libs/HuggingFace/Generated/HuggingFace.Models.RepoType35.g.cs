
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType35
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
    public static class RepoType35Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType35 value)
        {
            return value switch
            {
                RepoType35.Models => "models",
                RepoType35.Spaces => "spaces",
                RepoType35.Datasets => "datasets",
                RepoType35.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType35? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType35.Models,
                "spaces" => RepoType35.Spaces,
                "datasets" => RepoType35.Datasets,
                "kernels" => RepoType35.Kernels,
                _ => null,
            };
        }
    }
}