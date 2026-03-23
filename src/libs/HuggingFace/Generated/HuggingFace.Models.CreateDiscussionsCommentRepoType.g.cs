
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsCommentRepoType
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
    public static class CreateDiscussionsCommentRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentRepoType value)
        {
            return value switch
            {
                CreateDiscussionsCommentRepoType.Datasets => "datasets",
                CreateDiscussionsCommentRepoType.Kernels => "kernels",
                CreateDiscussionsCommentRepoType.Models => "models",
                CreateDiscussionsCommentRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => CreateDiscussionsCommentRepoType.Datasets,
                "kernels" => CreateDiscussionsCommentRepoType.Kernels,
                "models" => CreateDiscussionsCommentRepoType.Models,
                "spaces" => CreateDiscussionsCommentRepoType.Spaces,
                _ => null,
            };
        }
    }
}