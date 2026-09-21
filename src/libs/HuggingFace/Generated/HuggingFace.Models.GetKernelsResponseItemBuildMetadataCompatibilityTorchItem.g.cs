
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
        x211,
        /// <summary>
        ///
        /// </summary>
        x212,
        /// <summary>
        ///
        /// </summary>
        x213,
        /// <summary>
        ///
        /// </summary>
        x214,
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
                GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x211 => "2.11",
                GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x212 => "2.12",
                GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x213 => "2.13",
                GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x214 => "2.14",
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
                "2.11" => GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x211,
                "2.12" => GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x212,
                "2.13" => GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x213,
                "2.14" => GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x214,
                "2.8" => GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x28,
                "2.9" => GetKernelsResponseItemBuildMetadataCompatibilityTorchItem.x29,
                _ => null,
            };
        }
    }
}