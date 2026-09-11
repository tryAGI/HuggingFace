
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDiscussionsIgnoreRepoType
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
    public static class CreateDiscussionsIgnoreRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsIgnoreRepoType value)
        {
            return value switch
            {
                CreateDiscussionsIgnoreRepoType.Datasets => "datasets",
                CreateDiscussionsIgnoreRepoType.Kernels => "kernels",
                CreateDiscussionsIgnoreRepoType.Models => "models",
                CreateDiscussionsIgnoreRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsIgnoreRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => CreateDiscussionsIgnoreRepoType.Datasets,
                "kernels" => CreateDiscussionsIgnoreRepoType.Kernels,
                "models" => CreateDiscussionsIgnoreRepoType.Models,
                "spaces" => CreateDiscussionsIgnoreRepoType.Spaces,
                _ => null,
            };
        }
    }
}