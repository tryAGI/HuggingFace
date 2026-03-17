
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType50
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
    public static class RepoType50Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType50 value)
        {
            return value switch
            {
                RepoType50.Models => "models",
                RepoType50.Spaces => "spaces",
                RepoType50.Datasets => "datasets",
                RepoType50.Kernels => "kernels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType50? ToEnum(string value)
        {
            return value switch
            {
                "models" => RepoType50.Models,
                "spaces" => RepoType50.Spaces,
                "datasets" => RepoType50.Datasets,
                "kernels" => RepoType50.Kernels,
                _ => null,
            };
        }
    }
}