
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDiscussionsCommentReactionRepoType
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
    public static class CreateDiscussionsCommentReactionRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentReactionRepoType value)
        {
            return value switch
            {
                CreateDiscussionsCommentReactionRepoType.Datasets => "datasets",
                CreateDiscussionsCommentReactionRepoType.Kernels => "kernels",
                CreateDiscussionsCommentReactionRepoType.Models => "models",
                CreateDiscussionsCommentReactionRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentReactionRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => CreateDiscussionsCommentReactionRepoType.Datasets,
                "kernels" => CreateDiscussionsCommentReactionRepoType.Kernels,
                "models" => CreateDiscussionsCommentReactionRepoType.Models,
                "spaces" => CreateDiscussionsCommentReactionRepoType.Spaces,
                _ => null,
            };
        }
    }
}