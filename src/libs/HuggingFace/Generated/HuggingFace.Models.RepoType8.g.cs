
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType8
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
    public static class RepoType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType8 value)
        {
            return value switch
            {
                RepoType8.Models => "models",
                RepoType8.Spaces => "spaces",
                RepoType8.Datasets => "datasets",
                RepoType8.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType8? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType8.Models,
                "spaces" => RepoType8.Spaces,
                "datasets" => RepoType8.Datasets,
                "kernels" => RepoType8.Kernels,
                _ => null,
            };
        }
    }
}