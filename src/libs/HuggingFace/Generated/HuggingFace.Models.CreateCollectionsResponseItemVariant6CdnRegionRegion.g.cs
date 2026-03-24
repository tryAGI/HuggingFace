
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant6CdnRegionRegion
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
    public static class CreateCollectionsResponseItemVariant6CdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant6CdnRegionRegion value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant6CdnRegionRegion.Eu => "eu",
                CreateCollectionsResponseItemVariant6CdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant6CdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CreateCollectionsResponseItemVariant6CdnRegionRegion.Eu,
                "us" => CreateCollectionsResponseItemVariant6CdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}