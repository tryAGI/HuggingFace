
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant6CdnRegionProvider2
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
    public static class PatchCollectionsResponseDataItemVariant6CdnRegionProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant6CdnRegionProvider2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant6CdnRegionProvider2.Aws => "aws",
                PatchCollectionsResponseDataItemVariant6CdnRegionProvider2.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant6CdnRegionProvider2? ToEnum(string value)
        {
            return value switch
            {
                "aws" => PatchCollectionsResponseDataItemVariant6CdnRegionProvider2.Aws,
                "gcp" => PatchCollectionsResponseDataItemVariant6CdnRegionProvider2.Gcp,
                _ => null,
            };
        }
    }
}