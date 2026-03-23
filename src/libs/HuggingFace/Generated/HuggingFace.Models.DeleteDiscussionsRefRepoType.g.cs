
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteDiscussionsRefRepoType
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
    public static class DeleteDiscussionsRefRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteDiscussionsRefRepoType value)
        {
            return value switch
            {
                DeleteDiscussionsRefRepoType.Datasets => "datasets",
                DeleteDiscussionsRefRepoType.Kernels => "kernels",
                DeleteDiscussionsRefRepoType.Models => "models",
                DeleteDiscussionsRefRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteDiscussionsRefRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => DeleteDiscussionsRefRepoType.Datasets,
                "kernels" => DeleteDiscussionsRefRepoType.Kernels,
                "models" => DeleteDiscussionsRefRepoType.Models,
                "spaces" => DeleteDiscussionsRefRepoType.Spaces,
                _ => null,
            };
        }
    }
}