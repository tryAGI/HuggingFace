
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBucketsResponseCdnRegionRegion
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
    public static class GetBucketsResponseCdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBucketsResponseCdnRegionRegion value)
        {
            return value switch
            {
                GetBucketsResponseCdnRegionRegion.Eu => "eu",
                GetBucketsResponseCdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBucketsResponseCdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => GetBucketsResponseCdnRegionRegion.Eu,
                "us" => GetBucketsResponseCdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}