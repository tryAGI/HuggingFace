
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutBucketsSettingsResponseCdnRegionProvider
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
    public static class PutBucketsSettingsResponseCdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutBucketsSettingsResponseCdnRegionProvider value)
        {
            return value switch
            {
                PutBucketsSettingsResponseCdnRegionProvider.Aws => "aws",
                PutBucketsSettingsResponseCdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutBucketsSettingsResponseCdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => PutBucketsSettingsResponseCdnRegionProvider.Aws,
                "gcp" => PutBucketsSettingsResponseCdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}