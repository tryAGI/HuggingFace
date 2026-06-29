
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsResponseItemBuildMetadataCompatibilityTorchItem
    {
        /// <summary>
        /// 
        /// </summary>
        x210,
        /// <summary>
        /// 
        /// </summary>
        x28,
        /// <summary>
        /// 
        /// </summary>
        x29,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKernelsResponseItemBuildMetadataCompatibilityTorchItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsResponseItemBuildMetadataCompatibilityTorchItem value)
        {
            return value switch
            {
                GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x210 => "2.10",
                GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x28 => "2.8",
                GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x29 => "2.9",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsResponseItemBuildMetadataCompatibilityTorchItem? ToEnum(string value)
        {
            return value switch
            {
                "2.10" => GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x210,
                "2.8" => GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x28,
                "2.9" => GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x29,
                _ => null,
            };
        }
    }
}