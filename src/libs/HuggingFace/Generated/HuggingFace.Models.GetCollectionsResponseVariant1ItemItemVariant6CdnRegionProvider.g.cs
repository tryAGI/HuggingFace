
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant6CdnRegionProvider
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
    public static class GetCollectionsResponseVariant1ItemItemVariant6CdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant6CdnRegionProvider value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant6CdnRegionProvider.Aws => "aws",
                GetCollectionsResponseVariant1ItemItemVariant6CdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant6CdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => GetCollectionsResponseVariant1ItemItemVariant6CdnRegionProvider.Aws,
                "gcp" => GetCollectionsResponseVariant1ItemItemVariant6CdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}