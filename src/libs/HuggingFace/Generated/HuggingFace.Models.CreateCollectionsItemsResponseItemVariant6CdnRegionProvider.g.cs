
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant6CdnRegionProvider
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
    public static class CreateCollectionsItemsResponseItemVariant6CdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant6CdnRegionProvider value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant6CdnRegionProvider.Aws => "aws",
                CreateCollectionsItemsResponseItemVariant6CdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant6CdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => CreateCollectionsItemsResponseItemVariant6CdnRegionProvider.Aws,
                "gcp" => CreateCollectionsItemsResponseItemVariant6CdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}