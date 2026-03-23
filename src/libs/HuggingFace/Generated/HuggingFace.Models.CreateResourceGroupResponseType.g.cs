
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateResourceGroupResponseType
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
    public static class CreateResourceGroupResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResourceGroupResponseType value)
        {
            return value switch
            {
                CreateResourceGroupResponseType.Bucket => "bucket",
                CreateResourceGroupResponseType.Dataset => "dataset",
                CreateResourceGroupResponseType.Kernel => "kernel",
                CreateResourceGroupResponseType.Model => "model",
                CreateResourceGroupResponseType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResourceGroupResponseType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateResourceGroupResponseType.Bucket,
                "dataset" => CreateResourceGroupResponseType.Dataset,
                "kernel" => CreateResourceGroupResponseType.Kernel,
                "model" => CreateResourceGroupResponseType.Model,
                "space" => CreateResourceGroupResponseType.Space,
                _ => null,
            };
        }
    }
}