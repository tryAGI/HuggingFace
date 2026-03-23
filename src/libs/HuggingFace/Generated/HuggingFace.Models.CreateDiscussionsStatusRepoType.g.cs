
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsStatusRepoType
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
    public static class CreateDiscussionsStatusRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsStatusRepoType value)
        {
            return value switch
            {
                CreateDiscussionsStatusRepoType.Datasets => "datasets",
                CreateDiscussionsStatusRepoType.Kernels => "kernels",
                CreateDiscussionsStatusRepoType.Models => "models",
                CreateDiscussionsStatusRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsStatusRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => CreateDiscussionsStatusRepoType.Datasets,
                "kernels" => CreateDiscussionsStatusRepoType.Kernels,
                "models" => CreateDiscussionsStatusRepoType.Models,
                "spaces" => CreateDiscussionsStatusRepoType.Spaces,
                _ => null,
            };
        }
    }
}