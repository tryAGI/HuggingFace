
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateKernelsLfsFilesDuplicateRequestTargetType
    {
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Kernel,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKernelsLfsFilesDuplicateRequestTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKernelsLfsFilesDuplicateRequestTargetType value)
        {
            return value switch
            {
                CreateKernelsLfsFilesDuplicateRequestTargetType.Dataset => "dataset",
                CreateKernelsLfsFilesDuplicateRequestTargetType.Kernel => "kernel",
                CreateKernelsLfsFilesDuplicateRequestTargetType.Model => "model",
                CreateKernelsLfsFilesDuplicateRequestTargetType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKernelsLfsFilesDuplicateRequestTargetType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => CreateKernelsLfsFilesDuplicateRequestTargetType.Dataset,
                "kernel" => CreateKernelsLfsFilesDuplicateRequestTargetType.Kernel,
                "model" => CreateKernelsLfsFilesDuplicateRequestTargetType.Model,
                "space" => CreateKernelsLfsFilesDuplicateRequestTargetType.Space,
                _ => null,
            };
        }
    }
}