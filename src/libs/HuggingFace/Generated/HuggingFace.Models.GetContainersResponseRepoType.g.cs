
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetContainersResponseRepoType
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
    public static class GetContainersResponseRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContainersResponseRepoType value)
        {
            return value switch
            {
                GetContainersResponseRepoType.Bucket => "bucket",
                GetContainersResponseRepoType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContainersResponseRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetContainersResponseRepoType.Bucket,
                "container" => GetContainersResponseRepoType.Container,
                _ => null,
            };
        }
    }
}