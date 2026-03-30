
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsRevisionResponseSupportedDriverFamilie
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
    public static class GetKernelsRevisionResponseSupportedDriverFamilieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsRevisionResponseSupportedDriverFamilie value)
        {
            return value switch
            {
                GetKernelsRevisionResponseSupportedDriverFamilie.Cpu => "cpu",
                GetKernelsRevisionResponseSupportedDriverFamilie.Cuda => "cuda",
                GetKernelsRevisionResponseSupportedDriverFamilie.Metal => "metal",
                GetKernelsRevisionResponseSupportedDriverFamilie.Rocm => "rocm",
                GetKernelsRevisionResponseSupportedDriverFamilie.Xpu => "xpu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsRevisionResponseSupportedDriverFamilie? ToEnum(string value)
        {
            return value switch
            {
                "cpu" => GetKernelsRevisionResponseSupportedDriverFamilie.Cpu,
                "cuda" => GetKernelsRevisionResponseSupportedDriverFamilie.Cuda,
                "metal" => GetKernelsRevisionResponseSupportedDriverFamilie.Metal,
                "rocm" => GetKernelsRevisionResponseSupportedDriverFamilie.Rocm,
                "xpu" => GetKernelsRevisionResponseSupportedDriverFamilie.Xpu,
                _ => null,
            };
        }
    }
}