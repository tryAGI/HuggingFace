
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant6CdnRegionRegion2
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
    public static class CreateCollectionsItemsResponseItemVariant6CdnRegionRegion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant6CdnRegionRegion2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant6CdnRegionRegion2.Eu => "eu",
                CreateCollectionsItemsResponseItemVariant6CdnRegionRegion2.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant6CdnRegionRegion2? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CreateCollectionsItemsResponseItemVariant6CdnRegionRegion2.Eu,
                "us" => CreateCollectionsItemsResponseItemVariant6CdnRegionRegion2.Us,
                _ => null,
            };
        }
    }
}