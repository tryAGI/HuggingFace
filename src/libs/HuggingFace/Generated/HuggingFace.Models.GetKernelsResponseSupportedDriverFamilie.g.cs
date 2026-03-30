
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsResponseSupportedDriverFamilie
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
    public static class GetKernelsResponseSupportedDriverFamilieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsResponseSupportedDriverFamilie value)
        {
            return value switch
            {
                GetKernelsResponseSupportedDriverFamilie.Cpu => "cpu",
                GetKernelsResponseSupportedDriverFamilie.Cuda => "cuda",
                GetKernelsResponseSupportedDriverFamilie.Metal => "metal",
                GetKernelsResponseSupportedDriverFamilie.Rocm => "rocm",
                GetKernelsResponseSupportedDriverFamilie.Xpu => "xpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsResponseSupportedDriverFamilie? ToEnum(string value)
        {
            return value switch
            {
                "cpu" => GetKernelsResponseSupportedDriverFamilie.Cpu,
                "cuda" => GetKernelsResponseSupportedDriverFamilie.Cuda,
                "metal" => GetKernelsResponseSupportedDriverFamilie.Metal,
                "rocm" => GetKernelsResponseSupportedDriverFamilie.Rocm,
                "xpu" => GetKernelsResponseSupportedDriverFamilie.Xpu,
                _ => null,
            };
        }
    }
}