
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutBucketsSettingsResponseCdnRegionRegion
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
    public static class PutBucketsSettingsResponseCdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutBucketsSettingsResponseCdnRegionRegion value)
        {
            return value switch
            {
                PutBucketsSettingsResponseCdnRegionRegion.Eu => "eu",
                PutBucketsSettingsResponseCdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutBucketsSettingsResponseCdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => PutBucketsSettingsResponseCdnRegionRegion.Eu,
                "us" => PutBucketsSettingsResponseCdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}