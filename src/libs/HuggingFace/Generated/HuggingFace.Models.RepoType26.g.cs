
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType26
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
    public static class RepoType26Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType26 value)
        {
            return value switch
            {
                RepoType26.Models => "models",
                RepoType26.Spaces => "spaces",
                RepoType26.Datasets => "datasets",
                RepoType26.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType26? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType26.Models,
                "spaces" => RepoType26.Spaces,
                "datasets" => RepoType26.Datasets,
                "kernels" => RepoType26.Kernels,
                _ => null,
            };
        }
    }
}