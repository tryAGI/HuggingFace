
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutBucketsSettingsRequestCdnRegionRegion
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
    public static class PutBucketsSettingsRequestCdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutBucketsSettingsRequestCdnRegionRegion value)
        {
            return value switch
            {
                PutBucketsSettingsRequestCdnRegionRegion.Eu => "eu",
                PutBucketsSettingsRequestCdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutBucketsSettingsRequestCdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => PutBucketsSettingsRequestCdnRegionRegion.Eu,
                "us" => PutBucketsSettingsRequestCdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}