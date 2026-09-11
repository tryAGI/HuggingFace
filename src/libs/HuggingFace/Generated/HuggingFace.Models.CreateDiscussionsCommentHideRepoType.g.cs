
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDiscussionsCommentHideRepoType
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
    public static class CreateDiscussionsCommentHideRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentHideRepoType value)
        {
            return value switch
            {
                CreateDiscussionsCommentHideRepoType.Datasets => "datasets",
                CreateDiscussionsCommentHideRepoType.Kernels => "kernels",
                CreateDiscussionsCommentHideRepoType.Models => "models",
                CreateDiscussionsCommentHideRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentHideRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => CreateDiscussionsCommentHideRepoType.Datasets,
                "kernels" => CreateDiscussionsCommentHideRepoType.Kernels,
                "models" => CreateDiscussionsCommentHideRepoType.Models,
                "spaces" => CreateDiscussionsCommentHideRepoType.Spaces,
                _ => null,
            };
        }
    }
}