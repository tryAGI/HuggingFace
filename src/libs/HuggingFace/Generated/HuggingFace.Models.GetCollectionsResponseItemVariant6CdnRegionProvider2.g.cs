
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant6CdnRegionProvider2
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
    public static class GetCollectionsResponseItemVariant6CdnRegionProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant6CdnRegionProvider2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant6CdnRegionProvider2.Aws => "aws",
                GetCollectionsResponseItemVariant6CdnRegionProvider2.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant6CdnRegionProvider2? ToEnum(string value)
        {
            return value switch
            {
                "aws" => GetCollectionsResponseItemVariant6CdnRegionProvider2.Aws,
                "gcp" => GetCollectionsResponseItemVariant6CdnRegionProvider2.Gcp,
                _ => null,
            };
        }
    }
}