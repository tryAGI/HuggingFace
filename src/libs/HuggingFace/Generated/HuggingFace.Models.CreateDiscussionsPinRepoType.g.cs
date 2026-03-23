
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsPinRepoType
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
    public static class CreateDiscussionsPinRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsPinRepoType value)
        {
            return value switch
            {
                CreateDiscussionsPinRepoType.Datasets => "datasets",
                CreateDiscussionsPinRepoType.Kernels => "kernels",
                CreateDiscussionsPinRepoType.Models => "models",
                CreateDiscussionsPinRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsPinRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => CreateDiscussionsPinRepoType.Datasets,
                "kernels" => CreateDiscussionsPinRepoType.Kernels,
                "models" => CreateDiscussionsPinRepoType.Models,
                "spaces" => CreateDiscussionsPinRepoType.Spaces,
                _ => null,
            };
        }
    }
}