
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsResponseItemBuildMetadataCompatibilityO
    {
        /// <summary>
        /// 
        /// </summary>
        Linux,
        /// <summary>
        /// 
        /// </summary>
        Macos,
        /// <summary>
        /// 
        /// </summary>
        Windows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKernelsResponseItemBuildMetadataCompatibilityOExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsResponseItemBuildMetadataCompatibilityO value)
        {
            return value switch
            {
                GetKernelsResponseItemBuildMetadataCompatibilityO.Linux => "linux",
                GetKernelsResponseItemBuildMetadataCompatibilityO.Macos => "macos",
                GetKernelsResponseItemBuildMetadataCompatibilityO.Windows => "windows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsResponseItemBuildMetadataCompatibilityO? ToEnum(string value)
        {
            return value switch
            {
                "linux" => GetKernelsResponseItemBuildMetadataCompatibilityO.Linux,
                "macos" => GetKernelsResponseItemBuildMetadataCompatibilityO.Macos,
                "windows" => GetKernelsResponseItemBuildMetadataCompatibilityO.Windows,
                _ => null,
            };
        }
    }
}