
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant6CdnRegionProvider
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
    public static class CreateCollectionsResponseItemVariant6CdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant6CdnRegionProvider value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant6CdnRegionProvider.Aws => "aws",
                CreateCollectionsResponseItemVariant6CdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant6CdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => CreateCollectionsResponseItemVariant6CdnRegionProvider.Aws,
                "gcp" => CreateCollectionsResponseItemVariant6CdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}