
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType10
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
    public static class RepoType10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType10 value)
        {
            return value switch
            {
                RepoType10.Models => "models",
                RepoType10.Spaces => "spaces",
                RepoType10.Datasets => "datasets",
                RepoType10.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType10? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType10.Models,
                "spaces" => RepoType10.Spaces,
                "datasets" => RepoType10.Datasets,
                "kernels" => RepoType10.Kernels,
                _ => null,
            };
        }
    }
}