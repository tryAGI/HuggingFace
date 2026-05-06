
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBucketsResponseItemCdnRegionRegion
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
    public static class GetBucketsResponseItemCdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBucketsResponseItemCdnRegionRegion value)
        {
            return value switch
            {
                GetBucketsResponseItemCdnRegionRegion.Eu => "eu",
                GetBucketsResponseItemCdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBucketsResponseItemCdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => GetBucketsResponseItemCdnRegionRegion.Eu,
                "us" => GetBucketsResponseItemCdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}