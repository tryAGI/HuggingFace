
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetQuicksearchRepoType2
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
    public static class GetQuicksearchRepoType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetQuicksearchRepoType2 value)
        {
            return value switch
            {
                GetQuicksearchRepoType2.Bucket => "bucket",
                GetQuicksearchRepoType2.Dataset => "dataset",
                GetQuicksearchRepoType2.Kernel => "kernel",
                GetQuicksearchRepoType2.Model => "model",
                GetQuicksearchRepoType2.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetQuicksearchRepoType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetQuicksearchRepoType2.Bucket,
                "dataset" => GetQuicksearchRepoType2.Dataset,
                "kernel" => GetQuicksearchRepoType2.Kernel,
                "model" => GetQuicksearchRepoType2.Model,
                "space" => GetQuicksearchRepoType2.Space,
                _ => null,
            };
        }
    }
}