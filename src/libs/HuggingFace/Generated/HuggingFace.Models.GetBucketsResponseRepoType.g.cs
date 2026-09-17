
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetBucketsResponseRepoType
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
    public static class GetBucketsResponseRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBucketsResponseRepoType value)
        {
            return value switch
            {
                GetBucketsResponseRepoType.Bucket => "bucket",
                GetBucketsResponseRepoType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBucketsResponseRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetBucketsResponseRepoType.Bucket,
                "container" => GetBucketsResponseRepoType.Container,
                _ => null,
            };
        }
    }
}