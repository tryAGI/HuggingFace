
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutBucketsSettingsRequestCdnRegionProvider
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
    public static class PutBucketsSettingsRequestCdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutBucketsSettingsRequestCdnRegionProvider value)
        {
            return value switch
            {
                PutBucketsSettingsRequestCdnRegionProvider.Aws => "aws",
                PutBucketsSettingsRequestCdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutBucketsSettingsRequestCdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => PutBucketsSettingsRequestCdnRegionProvider.Aws,
                "gcp" => PutBucketsSettingsRequestCdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}