
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: model
    /// </summary>
    public enum CreateReposMoveRequestType
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
    public static class CreateReposMoveRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposMoveRequestType value)
        {
            return value switch
            {
                CreateReposMoveRequestType.Bucket => "bucket",
                CreateReposMoveRequestType.Dataset => "dataset",
                CreateReposMoveRequestType.Kernel => "kernel",
                CreateReposMoveRequestType.Model => "model",
                CreateReposMoveRequestType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposMoveRequestType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateReposMoveRequestType.Bucket,
                "dataset" => CreateReposMoveRequestType.Dataset,
                "kernel" => CreateReposMoveRequestType.Kernel,
                "model" => CreateReposMoveRequestType.Model,
                "space" => CreateReposMoveRequestType.Space,
                _ => null,
            };
        }
    }
}