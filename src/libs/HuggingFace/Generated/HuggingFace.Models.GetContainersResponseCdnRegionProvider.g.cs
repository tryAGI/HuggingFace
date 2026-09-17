
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetContainersResponseCdnRegionProvider
    {
        /// <summary>
        ///
        /// </summary>
        Aws,
        /// <summary>
        ///
        /// </summary>
        Gcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetContainersResponseCdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContainersResponseCdnRegionProvider value)
        {
            return value switch
            {
                GetContainersResponseCdnRegionProvider.Aws => "aws",
                GetContainersResponseCdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContainersResponseCdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => GetContainersResponseCdnRegionProvider.Aws,
                "gcp" => GetContainersResponseCdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}