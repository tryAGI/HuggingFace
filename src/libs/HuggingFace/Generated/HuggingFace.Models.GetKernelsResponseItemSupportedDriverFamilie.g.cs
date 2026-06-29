
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsResponseItemSupportedDriverFamilie
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
    public static class GetKernelsResponseItemSupportedDriverFamilieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsResponseItemSupportedDriverFamilie value)
        {
            return value switch
            {
                GetKernelsResponseItemSupportedDriverFamilie.Cpu => "cpu",
                GetKernelsResponseItemSupportedDriverFamilie.Cuda => "cuda",
                GetKernelsResponseItemSupportedDriverFamilie.Metal => "metal",
                GetKernelsResponseItemSupportedDriverFamilie.Rocm => "rocm",
                GetKernelsResponseItemSupportedDriverFamilie.Xpu => "xpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsResponseItemSupportedDriverFamilie? ToEnum(string value)
        {
            return value switch
            {
                "cpu" => GetKernelsResponseItemSupportedDriverFamilie.Cpu,
                "cuda" => GetKernelsResponseItemSupportedDriverFamilie.Cuda,
                "metal" => GetKernelsResponseItemSupportedDriverFamilie.Metal,
                "rocm" => GetKernelsResponseItemSupportedDriverFamilie.Rocm,
                "xpu" => GetKernelsResponseItemSupportedDriverFamilie.Xpu,
                _ => null,
            };
        }
    }
}