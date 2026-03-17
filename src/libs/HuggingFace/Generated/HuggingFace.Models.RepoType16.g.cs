
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType16
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
    public static class RepoType16Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType16 value)
        {
            return value switch
            {
                RepoType16.Models => "models",
                RepoType16.Spaces => "spaces",
                RepoType16.Datasets => "datasets",
                RepoType16.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType16? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType16.Models,
                "spaces" => RepoType16.Spaces,
                "datasets" => RepoType16.Datasets,
                "kernels" => RepoType16.Kernels,
                _ => null,
            };
        }
    }
}