
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesLfsFilesDuplicateRequestTargetType
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
    public static class CreateSpacesLfsFilesDuplicateRequestTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesLfsFilesDuplicateRequestTargetType value)
        {
            return value switch
            {
                CreateSpacesLfsFilesDuplicateRequestTargetType.Dataset => "dataset",
                CreateSpacesLfsFilesDuplicateRequestTargetType.Kernel => "kernel",
                CreateSpacesLfsFilesDuplicateRequestTargetType.Model => "model",
                CreateSpacesLfsFilesDuplicateRequestTargetType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesLfsFilesDuplicateRequestTargetType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => CreateSpacesLfsFilesDuplicateRequestTargetType.Dataset,
                "kernel" => CreateSpacesLfsFilesDuplicateRequestTargetType.Kernel,
                "model" => CreateSpacesLfsFilesDuplicateRequestTargetType.Model,
                "space" => CreateSpacesLfsFilesDuplicateRequestTargetType.Space,
                _ => null,
            };
        }
    }
}