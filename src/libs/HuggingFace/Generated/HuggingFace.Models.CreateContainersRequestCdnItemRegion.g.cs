
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateContainersRequestCdnItemRegion
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
    public static class CreateContainersRequestCdnItemRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContainersRequestCdnItemRegion value)
        {
            return value switch
            {
                CreateContainersRequestCdnItemRegion.Eu => "eu",
                CreateContainersRequestCdnItemRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContainersRequestCdnItemRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CreateContainersRequestCdnItemRegion.Eu,
                "us" => CreateContainersRequestCdnItemRegion.Us,
                _ => null,
            };
        }
    }
}