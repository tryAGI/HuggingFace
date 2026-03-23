
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsRepoType2
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
    public static class GetDiscussionsRepoType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsRepoType2 value)
        {
            return value switch
            {
                GetDiscussionsRepoType2.Datasets => "datasets",
                GetDiscussionsRepoType2.Kernels => "kernels",
                GetDiscussionsRepoType2.Models => "models",
                GetDiscussionsRepoType2.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsRepoType2? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => GetDiscussionsRepoType2.Datasets,
                "kernels" => GetDiscussionsRepoType2.Kernels,
                "models" => GetDiscussionsRepoType2.Models,
                "spaces" => GetDiscussionsRepoType2.Spaces,
                _ => null,
            };
        }
    }
}