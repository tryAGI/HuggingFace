
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsLfsFilesDuplicateRequestTargetType
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
    public static class CreateModelsLfsFilesDuplicateRequestTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsLfsFilesDuplicateRequestTargetType value)
        {
            return value switch
            {
                CreateModelsLfsFilesDuplicateRequestTargetType.Dataset => "dataset",
                CreateModelsLfsFilesDuplicateRequestTargetType.Kernel => "kernel",
                CreateModelsLfsFilesDuplicateRequestTargetType.Model => "model",
                CreateModelsLfsFilesDuplicateRequestTargetType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsLfsFilesDuplicateRequestTargetType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => CreateModelsLfsFilesDuplicateRequestTargetType.Dataset,
                "kernel" => CreateModelsLfsFilesDuplicateRequestTargetType.Kernel,
                "model" => CreateModelsLfsFilesDuplicateRequestTargetType.Model,
                "space" => CreateModelsLfsFilesDuplicateRequestTargetType.Space,
                _ => null,
            };
        }
    }
}