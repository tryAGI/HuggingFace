
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateResourceGroupRepoType
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
    public static class CreateResourceGroupRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResourceGroupRepoType value)
        {
            return value switch
            {
                CreateResourceGroupRepoType.Buckets => "buckets",
                CreateResourceGroupRepoType.Datasets => "datasets",
                CreateResourceGroupRepoType.Kernels => "kernels",
                CreateResourceGroupRepoType.Models => "models",
                CreateResourceGroupRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResourceGroupRepoType? ToEnum(string value)
        {
            return value switch
            {
                "buckets" => CreateResourceGroupRepoType.Buckets,
                "datasets" => CreateResourceGroupRepoType.Datasets,
                "kernels" => CreateResourceGroupRepoType.Kernels,
                "models" => CreateResourceGroupRepoType.Models,
                "spaces" => CreateResourceGroupRepoType.Spaces,
                _ => null,
            };
        }
    }
}