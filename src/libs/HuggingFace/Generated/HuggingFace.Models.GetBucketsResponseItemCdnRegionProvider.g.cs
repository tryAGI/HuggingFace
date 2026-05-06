
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBucketsResponseItemCdnRegionProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Aws,
        /// <summary>
        /// 
        /// </summary>
        Gcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBucketsResponseItemCdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBucketsResponseItemCdnRegionProvider value)
        {
            return value switch
            {
                GetBucketsResponseItemCdnRegionProvider.Aws => "aws",
                GetBucketsResponseItemCdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBucketsResponseItemCdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => GetBucketsResponseItemCdnRegionProvider.Aws,
                "gcp" => GetBucketsResponseItemCdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}