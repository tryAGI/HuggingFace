
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsRepoType
    {
        /// <summary>
        /// 
        /// </summary>
        Datasets,
        /// <summary>
        /// 
        /// </summary>
        Kernels,
        /// <summary>
        /// 
        /// </summary>
        Models,
        /// <summary>
        /// 
        /// </summary>
        Spaces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDiscussionsRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsRepoType value)
        {
            return value switch
            {
                GetDiscussionsRepoType.Datasets => "datasets",
                GetDiscussionsRepoType.Kernels => "kernels",
                GetDiscussionsRepoType.Models => "models",
                GetDiscussionsRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => GetDiscussionsRepoType.Datasets,
                "kernels" => GetDiscussionsRepoType.Kernels,
                "models" => GetDiscussionsRepoType.Models,
                "spaces" => GetDiscussionsRepoType.Spaces,
                _ => null,
            };
        }
    }
}