
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesResourceGroupResponseType
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
    public static class CreateSpacesResourceGroupResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesResourceGroupResponseType value)
        {
            return value switch
            {
                CreateSpacesResourceGroupResponseType.Bucket => "bucket",
                CreateSpacesResourceGroupResponseType.Dataset => "dataset",
                CreateSpacesResourceGroupResponseType.Kernel => "kernel",
                CreateSpacesResourceGroupResponseType.Model => "model",
                CreateSpacesResourceGroupResponseType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesResourceGroupResponseType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateSpacesResourceGroupResponseType.Bucket,
                "dataset" => CreateSpacesResourceGroupResponseType.Dataset,
                "kernel" => CreateSpacesResourceGroupResponseType.Kernel,
                "model" => CreateSpacesResourceGroupResponseType.Model,
                "space" => CreateSpacesResourceGroupResponseType.Space,
                _ => null,
            };
        }
    }
}