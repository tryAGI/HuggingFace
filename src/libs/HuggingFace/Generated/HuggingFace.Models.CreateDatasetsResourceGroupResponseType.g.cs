
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsResourceGroupResponseType
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
    public static class CreateDatasetsResourceGroupResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsResourceGroupResponseType value)
        {
            return value switch
            {
                CreateDatasetsResourceGroupResponseType.Bucket => "bucket",
                CreateDatasetsResourceGroupResponseType.Dataset => "dataset",
                CreateDatasetsResourceGroupResponseType.Kernel => "kernel",
                CreateDatasetsResourceGroupResponseType.Model => "model",
                CreateDatasetsResourceGroupResponseType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsResourceGroupResponseType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateDatasetsResourceGroupResponseType.Bucket,
                "dataset" => CreateDatasetsResourceGroupResponseType.Dataset,
                "kernel" => CreateDatasetsResourceGroupResponseType.Kernel,
                "model" => CreateDatasetsResourceGroupResponseType.Model,
                "space" => CreateDatasetsResourceGroupResponseType.Space,
                _ => null,
            };
        }
    }
}