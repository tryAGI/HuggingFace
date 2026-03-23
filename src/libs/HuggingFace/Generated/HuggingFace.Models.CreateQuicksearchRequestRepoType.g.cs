
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQuicksearchRequestRepoType
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
    public static class CreateQuicksearchRequestRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchRequestRepoType value)
        {
            return value switch
            {
                CreateQuicksearchRequestRepoType.Bucket => "bucket",
                CreateQuicksearchRequestRepoType.Dataset => "dataset",
                CreateQuicksearchRequestRepoType.Kernel => "kernel",
                CreateQuicksearchRequestRepoType.Model => "model",
                CreateQuicksearchRequestRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchRequestRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateQuicksearchRequestRepoType.Bucket,
                "dataset" => CreateQuicksearchRequestRepoType.Dataset,
                "kernel" => CreateQuicksearchRequestRepoType.Kernel,
                "model" => CreateQuicksearchRequestRepoType.Model,
                "space" => CreateQuicksearchRequestRepoType.Space,
                _ => null,
            };
        }
    }
}