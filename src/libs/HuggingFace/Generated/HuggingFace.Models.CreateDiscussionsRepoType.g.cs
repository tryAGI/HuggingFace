
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsRepoType
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
    public static class CreateDiscussionsRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsRepoType value)
        {
            return value switch
            {
                CreateDiscussionsRepoType.Datasets => "datasets",
                CreateDiscussionsRepoType.Kernels => "kernels",
                CreateDiscussionsRepoType.Models => "models",
                CreateDiscussionsRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => CreateDiscussionsRepoType.Datasets,
                "kernels" => CreateDiscussionsRepoType.Kernels,
                "models" => CreateDiscussionsRepoType.Models,
                "spaces" => CreateDiscussionsRepoType.Spaces,
                _ => null,
            };
        }
    }
}