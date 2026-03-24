
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant6CdnRegionRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Eu,
        /// <summary>
        /// 
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCollectionsResponseItemVariant6CdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant6CdnRegionRegion value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant6CdnRegionRegion.Eu => "eu",
                GetCollectionsResponseItemVariant6CdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant6CdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => GetCollectionsResponseItemVariant6CdnRegionRegion.Eu,
                "us" => GetCollectionsResponseItemVariant6CdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}