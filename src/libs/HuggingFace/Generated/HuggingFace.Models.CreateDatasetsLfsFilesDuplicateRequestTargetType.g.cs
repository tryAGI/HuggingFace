
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsLfsFilesDuplicateRequestTargetType
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
    public static class CreateDatasetsLfsFilesDuplicateRequestTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsLfsFilesDuplicateRequestTargetType value)
        {
            return value switch
            {
                CreateDatasetsLfsFilesDuplicateRequestTargetType.Dataset => "dataset",
                CreateDatasetsLfsFilesDuplicateRequestTargetType.Kernel => "kernel",
                CreateDatasetsLfsFilesDuplicateRequestTargetType.Model => "model",
                CreateDatasetsLfsFilesDuplicateRequestTargetType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsLfsFilesDuplicateRequestTargetType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => CreateDatasetsLfsFilesDuplicateRequestTargetType.Dataset,
                "kernel" => CreateDatasetsLfsFilesDuplicateRequestTargetType.Kernel,
                "model" => CreateDatasetsLfsFilesDuplicateRequestTargetType.Model,
                "space" => CreateDatasetsLfsFilesDuplicateRequestTargetType.Space,
                _ => null,
            };
        }
    }
}