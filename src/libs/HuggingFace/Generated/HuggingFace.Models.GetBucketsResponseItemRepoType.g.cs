
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetBucketsResponseItemRepoType
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
    public static class GetBucketsResponseItemRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBucketsResponseItemRepoType value)
        {
            return value switch
            {
                GetBucketsResponseItemRepoType.Bucket => "bucket",
                GetBucketsResponseItemRepoType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBucketsResponseItemRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetBucketsResponseItemRepoType.Bucket,
                "container" => GetBucketsResponseItemRepoType.Container,
                _ => null,
            };
        }
    }
}