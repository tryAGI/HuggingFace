
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsMergeRepoType
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
    public static class CreateDiscussionsMergeRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsMergeRepoType value)
        {
            return value switch
            {
                CreateDiscussionsMergeRepoType.Datasets => "datasets",
                CreateDiscussionsMergeRepoType.Kernels => "kernels",
                CreateDiscussionsMergeRepoType.Models => "models",
                CreateDiscussionsMergeRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsMergeRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => CreateDiscussionsMergeRepoType.Datasets,
                "kernels" => CreateDiscussionsMergeRepoType.Kernels,
                "models" => CreateDiscussionsMergeRepoType.Models,
                "spaces" => CreateDiscussionsMergeRepoType.Spaces,
                _ => null,
            };
        }
    }
}