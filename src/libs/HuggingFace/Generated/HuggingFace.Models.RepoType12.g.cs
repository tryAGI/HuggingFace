
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType12
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
    public static class RepoType12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType12 value)
        {
            return value switch
            {
                RepoType12.Models => "models",
                RepoType12.Spaces => "spaces",
                RepoType12.Datasets => "datasets",
                RepoType12.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType12? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType12.Models,
                "spaces" => RepoType12.Spaces,
                "datasets" => RepoType12.Datasets,
                "kernels" => RepoType12.Kernels,
                _ => null,
            };
        }
    }
}