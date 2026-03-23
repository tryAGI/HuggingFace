
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsStorageRepoType
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
    public static class GetDiscussionsStorageRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsStorageRepoType value)
        {
            return value switch
            {
                GetDiscussionsStorageRepoType.Datasets => "datasets",
                GetDiscussionsStorageRepoType.Kernels => "kernels",
                GetDiscussionsStorageRepoType.Models => "models",
                GetDiscussionsStorageRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsStorageRepoType? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => GetDiscussionsStorageRepoType.Datasets,
                "kernels" => GetDiscussionsStorageRepoType.Kernels,
                "models" => GetDiscussionsStorageRepoType.Models,
                "spaces" => GetDiscussionsStorageRepoType.Spaces,
                _ => null,
            };
        }
    }
}