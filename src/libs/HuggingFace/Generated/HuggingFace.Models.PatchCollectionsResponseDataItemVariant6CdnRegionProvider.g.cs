
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant6CdnRegionProvider
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
    public static class PatchCollectionsResponseDataItemVariant6CdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant6CdnRegionProvider value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant6CdnRegionProvider.Aws => "aws",
                PatchCollectionsResponseDataItemVariant6CdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant6CdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => PatchCollectionsResponseDataItemVariant6CdnRegionProvider.Aws,
                "gcp" => PatchCollectionsResponseDataItemVariant6CdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}