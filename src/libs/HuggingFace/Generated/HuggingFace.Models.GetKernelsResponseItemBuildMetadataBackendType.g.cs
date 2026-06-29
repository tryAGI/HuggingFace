
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsResponseItemBuildMetadataBackendType
    {
        /// <summary>
        /// 
        /// </summary>
        Cpu,
        /// <summary>
        /// 
        /// </summary>
        Cuda,
        /// <summary>
        /// 
        /// </summary>
        Metal,
        /// <summary>
        /// 
        /// </summary>
        Rocm,
        /// <summary>
        /// 
        /// </summary>
        Xpu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKernelsResponseItemBuildMetadataBackendTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsResponseItemBuildMetadataBackendType value)
        {
            return value switch
            {
                GetKernelsResponseItemBuildMetadataBackendType.Cpu => "cpu",
                GetKernelsResponseItemBuildMetadataBackendType.Cuda => "cuda",
                GetKernelsResponseItemBuildMetadataBackendType.Metal => "metal",
                GetKernelsResponseItemBuildMetadataBackendType.Rocm => "rocm",
                GetKernelsResponseItemBuildMetadataBackendType.Xpu => "xpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsResponseItemBuildMetadataBackendType? ToEnum(string value)
        {
            return value switch
            {
                "cpu" => GetKernelsResponseItemBuildMetadataBackendType.Cpu,
                "cuda" => GetKernelsResponseItemBuildMetadataBackendType.Cuda,
                "metal" => GetKernelsResponseItemBuildMetadataBackendType.Metal,
                "rocm" => GetKernelsResponseItemBuildMetadataBackendType.Rocm,
                "xpu" => GetKernelsResponseItemBuildMetadataBackendType.Xpu,
                _ => null,
            };
        }
    }
}