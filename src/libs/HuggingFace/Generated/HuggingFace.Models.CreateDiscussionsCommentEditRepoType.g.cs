
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDiscussionsCommentEditRepoType
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
    public static class CreateDiscussionsCommentEditRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentEditRepoType value)
        {
            return value switch
            {
                CreateDiscussionsCommentEditRepoType.Datasets => "datasets",
                CreateDiscussionsCommentEditRepoType.Kernels => "kernels",
                CreateDiscussionsCommentEditRepoType.Models => "models",
                CreateDiscussionsCommentEditRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentEditRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => CreateDiscussionsCommentEditRepoType.Datasets,
                "kernels" => CreateDiscussionsCommentEditRepoType.Kernels,
                "models" => CreateDiscussionsCommentEditRepoType.Models,
                "spaces" => CreateDiscussionsCommentEditRepoType.Spaces,
                _ => null,
            };
        }
    }
}