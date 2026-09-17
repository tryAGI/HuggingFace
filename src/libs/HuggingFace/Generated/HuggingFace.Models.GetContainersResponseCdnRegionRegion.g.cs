
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetContainersResponseCdnRegionRegion
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
    public static class GetContainersResponseCdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContainersResponseCdnRegionRegion value)
        {
            return value switch
            {
                GetContainersResponseCdnRegionRegion.Eu => "eu",
                GetContainersResponseCdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContainersResponseCdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => GetContainersResponseCdnRegionRegion.Eu,
                "us" => GetContainersResponseCdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}