
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsResponseItemBuildMetadataCompatibilityArchItem
    {
        /// <summary>
        /// 
        /// </summary>
        Aarch64,
        /// <summary>
        /// 
        /// </summary>
        Arm64,
        /// <summary>
        /// 
        /// </summary>
        X8664,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKernelsResponseItemBuildMetadataCompatibilityArchItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsResponseItemBuildMetadataCompatibilityArchItem value)
        {
            return value switch
            {
                GetKernelsResponseItemBuildMetadataCompatibilityArchItem.Aarch64 => "aarch64",
                GetKernelsResponseItemBuildMetadataCompatibilityArchItem.Arm64 => "arm64",
                GetKernelsResponseItemBuildMetadataCompatibilityArchItem.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsResponseItemBuildMetadataCompatibilityArchItem? ToEnum(string value)
        {
            return value switch
            {
                "aarch64" => GetKernelsResponseItemBuildMetadataCompatibilityArchItem.Aarch64,
                "arm64" => GetKernelsResponseItemBuildMetadataCompatibilityArchItem.Arm64,
                "x86_64" => GetKernelsResponseItemBuildMetadataCompatibilityArchItem.X8664,
                _ => null,
            };
        }
    }
}