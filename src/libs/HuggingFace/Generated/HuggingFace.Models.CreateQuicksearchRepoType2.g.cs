
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQuicksearchRepoType2
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
    public static class CreateQuicksearchRepoType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchRepoType2 value)
        {
            return value switch
            {
                CreateQuicksearchRepoType2.Bucket => "bucket",
                CreateQuicksearchRepoType2.Dataset => "dataset",
                CreateQuicksearchRepoType2.Kernel => "kernel",
                CreateQuicksearchRepoType2.Model => "model",
                CreateQuicksearchRepoType2.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchRepoType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateQuicksearchRepoType2.Bucket,
                "dataset" => CreateQuicksearchRepoType2.Dataset,
                "kernel" => CreateQuicksearchRepoType2.Kernel,
                "model" => CreateQuicksearchRepoType2.Model,
                "space" => CreateQuicksearchRepoType2.Space,
                _ => null,
            };
        }
    }
}