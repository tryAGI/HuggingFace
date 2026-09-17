
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetContainersResponseItemRepoType
    {
        /// <summary>
        ///
        /// </summary>
        Bucket,
        /// <summary>
        ///
        /// </summary>
        Container,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetContainersResponseItemRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContainersResponseItemRepoType value)
        {
            return value switch
            {
                GetContainersResponseItemRepoType.Bucket => "bucket",
                GetContainersResponseItemRepoType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContainersResponseItemRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetContainersResponseItemRepoType.Bucket,
                "container" => GetContainersResponseItemRepoType.Container,
                _ => null,
            };
        }
    }
}