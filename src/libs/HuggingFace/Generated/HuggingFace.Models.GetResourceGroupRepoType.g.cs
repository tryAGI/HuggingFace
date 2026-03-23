
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetResourceGroupRepoType
    {
        /// <summary>
        /// 
        /// </summary>
        Buckets,
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
    public static class GetResourceGroupRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResourceGroupRepoType value)
        {
            return value switch
            {
                GetResourceGroupRepoType.Buckets => "buckets",
                GetResourceGroupRepoType.Datasets => "datasets",
                GetResourceGroupRepoType.Kernels => "kernels",
                GetResourceGroupRepoType.Models => "models",
                GetResourceGroupRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResourceGroupRepoType? ToEnum(string value)
        {
            return value switch
            {
                "buckets" => GetResourceGroupRepoType.Buckets,
                "datasets" => GetResourceGroupRepoType.Datasets,
                "kernels" => GetResourceGroupRepoType.Kernels,
                "models" => GetResourceGroupRepoType.Models,
                "spaces" => GetResourceGroupRepoType.Spaces,
                _ => null,
            };
        }
    }
}