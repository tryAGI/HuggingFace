
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant6CdnRegionRegion
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
    public static class CreateCollectionsItemsResponseItemVariant6CdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant6CdnRegionRegion value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant6CdnRegionRegion.Eu => "eu",
                CreateCollectionsItemsResponseItemVariant6CdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant6CdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CreateCollectionsItemsResponseItemVariant6CdnRegionRegion.Eu,
                "us" => CreateCollectionsItemsResponseItemVariant6CdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}