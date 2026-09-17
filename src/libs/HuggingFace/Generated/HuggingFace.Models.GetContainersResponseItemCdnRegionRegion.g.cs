
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetContainersResponseItemCdnRegionRegion
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
    public static class GetContainersResponseItemCdnRegionRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContainersResponseItemCdnRegionRegion value)
        {
            return value switch
            {
                GetContainersResponseItemCdnRegionRegion.Eu => "eu",
                GetContainersResponseItemCdnRegionRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContainersResponseItemCdnRegionRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => GetContainersResponseItemCdnRegionRegion.Eu,
                "us" => GetContainersResponseItemCdnRegionRegion.Us,
                _ => null,
            };
        }
    }
}