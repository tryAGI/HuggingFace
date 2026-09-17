
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetContainersResponseItemCdnRegionProvider
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
    public static class GetContainersResponseItemCdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContainersResponseItemCdnRegionProvider value)
        {
            return value switch
            {
                GetContainersResponseItemCdnRegionProvider.Aws => "aws",
                GetContainersResponseItemCdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContainersResponseItemCdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => GetContainersResponseItemCdnRegionProvider.Aws,
                "gcp" => GetContainersResponseItemCdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}