
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant6CdnRegionProvider
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
    public static class GetCollectionsResponseItemVariant6CdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant6CdnRegionProvider value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant6CdnRegionProvider.Aws => "aws",
                GetCollectionsResponseItemVariant6CdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant6CdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => GetCollectionsResponseItemVariant6CdnRegionProvider.Aws,
                "gcp" => GetCollectionsResponseItemVariant6CdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}