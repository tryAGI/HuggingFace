
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant6CdnRegionRegion
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
    public static class GetCollectionsResponseVariant1ItemItemVariant6CdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant6CdnRegionRegion value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant6CdnRegionRegion.Eu => "eu",
                GetCollectionsResponseVariant1ItemItemVariant6CdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant6CdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => GetCollectionsResponseVariant1ItemItemVariant6CdnRegionRegion.Eu,
                "us" => GetCollectionsResponseVariant1ItemItemVariant6CdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}