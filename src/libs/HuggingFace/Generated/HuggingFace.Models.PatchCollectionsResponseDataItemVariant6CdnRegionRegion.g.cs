
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant6CdnRegionRegion
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
    public static class PatchCollectionsResponseDataItemVariant6CdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant6CdnRegionRegion value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant6CdnRegionRegion.Eu => "eu",
                PatchCollectionsResponseDataItemVariant6CdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant6CdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => PatchCollectionsResponseDataItemVariant6CdnRegionRegion.Eu,
                "us" => PatchCollectionsResponseDataItemVariant6CdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}