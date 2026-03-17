
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType11
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
    public static class RepoType11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType11 value)
        {
            return value switch
            {
                RepoType11.Models => "models",
                RepoType11.Spaces => "spaces",
                RepoType11.Datasets => "datasets",
                RepoType11.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType11? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType11.Models,
                "spaces" => RepoType11.Spaces,
                "datasets" => RepoType11.Datasets,
                "kernels" => RepoType11.Kernels,
                _ => null,
            };
        }
    }
}