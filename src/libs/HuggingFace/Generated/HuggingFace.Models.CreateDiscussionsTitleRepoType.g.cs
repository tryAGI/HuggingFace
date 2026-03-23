
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsTitleRepoType
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
    public static class CreateDiscussionsTitleRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsTitleRepoType value)
        {
            return value switch
            {
                CreateDiscussionsTitleRepoType.Datasets => "datasets",
                CreateDiscussionsTitleRepoType.Kernels => "kernels",
                CreateDiscussionsTitleRepoType.Models => "models",
                CreateDiscussionsTitleRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsTitleRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => CreateDiscussionsTitleRepoType.Datasets,
                "kernels" => CreateDiscussionsTitleRepoType.Kernels,
                "models" => CreateDiscussionsTitleRepoType.Models,
                "spaces" => CreateDiscussionsTitleRepoType.Spaces,
                _ => null,
            };
        }
    }
}