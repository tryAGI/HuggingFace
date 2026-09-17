
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutContainersSettingsRequestCdnRegionRegion
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
    public static class PutContainersSettingsRequestCdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutContainersSettingsRequestCdnRegionRegion value)
        {
            return value switch
            {
                PutContainersSettingsRequestCdnRegionRegion.Eu => "eu",
                PutContainersSettingsRequestCdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutContainersSettingsRequestCdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => PutContainersSettingsRequestCdnRegionRegion.Eu,
                "us" => PutContainersSettingsRequestCdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}