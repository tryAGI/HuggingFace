
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteDiscussionsRepoType
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
    public static class DeleteDiscussionsRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteDiscussionsRepoType value)
        {
            return value switch
            {
                DeleteDiscussionsRepoType.Datasets => "datasets",
                DeleteDiscussionsRepoType.Kernels => "kernels",
                DeleteDiscussionsRepoType.Models => "models",
                DeleteDiscussionsRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteDiscussionsRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => DeleteDiscussionsRepoType.Datasets,
                "kernels" => DeleteDiscussionsRepoType.Kernels,
                "models" => DeleteDiscussionsRepoType.Models,
                "spaces" => DeleteDiscussionsRepoType.Spaces,
                _ => null,
            };
        }
    }
}