
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsResourceGroupResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Bucket,
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
    public static class CreateModelsResourceGroupResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsResourceGroupResponseType value)
        {
            return value switch
            {
                CreateModelsResourceGroupResponseType.Bucket => "bucket",
                CreateModelsResourceGroupResponseType.Dataset => "dataset",
                CreateModelsResourceGroupResponseType.Kernel => "kernel",
                CreateModelsResourceGroupResponseType.Model => "model",
                CreateModelsResourceGroupResponseType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsResourceGroupResponseType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateModelsResourceGroupResponseType.Bucket,
                "dataset" => CreateModelsResourceGroupResponseType.Dataset,
                "kernel" => CreateModelsResourceGroupResponseType.Kernel,
                "model" => CreateModelsResourceGroupResponseType.Model,
                "space" => CreateModelsResourceGroupResponseType.Space,
                _ => null,
            };
        }
    }
}