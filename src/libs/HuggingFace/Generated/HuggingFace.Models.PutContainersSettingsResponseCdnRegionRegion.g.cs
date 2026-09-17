
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutContainersSettingsResponseCdnRegionRegion
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
    public static class PutContainersSettingsResponseCdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutContainersSettingsResponseCdnRegionRegion value)
        {
            return value switch
            {
                PutContainersSettingsResponseCdnRegionRegion.Eu => "eu",
                PutContainersSettingsResponseCdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutContainersSettingsResponseCdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => PutContainersSettingsResponseCdnRegionRegion.Eu,
                "us" => PutContainersSettingsResponseCdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}