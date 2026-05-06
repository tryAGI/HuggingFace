
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBucketsResponseCdnRegionProvider
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
    public static class GetBucketsResponseCdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBucketsResponseCdnRegionProvider value)
        {
            return value switch
            {
                GetBucketsResponseCdnRegionProvider.Aws => "aws",
                GetBucketsResponseCdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBucketsResponseCdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => GetBucketsResponseCdnRegionProvider.Aws,
                "gcp" => GetBucketsResponseCdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}