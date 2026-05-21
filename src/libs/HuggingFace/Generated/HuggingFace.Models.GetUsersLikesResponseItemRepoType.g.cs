
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetUsersLikesResponseItemRepoType
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
    public static class GetUsersLikesResponseItemRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsersLikesResponseItemRepoType value)
        {
            return value switch
            {
                GetUsersLikesResponseItemRepoType.Bucket => "bucket",
                GetUsersLikesResponseItemRepoType.Dataset => "dataset",
                GetUsersLikesResponseItemRepoType.Kernel => "kernel",
                GetUsersLikesResponseItemRepoType.Model => "model",
                GetUsersLikesResponseItemRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsersLikesResponseItemRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetUsersLikesResponseItemRepoType.Bucket,
                "dataset" => GetUsersLikesResponseItemRepoType.Dataset,
                "kernel" => GetUsersLikesResponseItemRepoType.Kernel,
                "model" => GetUsersLikesResponseItemRepoType.Model,
                "space" => GetUsersLikesResponseItemRepoType.Space,
                _ => null,
            };
        }
    }
}