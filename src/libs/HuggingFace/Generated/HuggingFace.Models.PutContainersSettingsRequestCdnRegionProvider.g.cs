
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutContainersSettingsRequestCdnRegionProvider
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
    public static class PutContainersSettingsRequestCdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutContainersSettingsRequestCdnRegionProvider value)
        {
            return value switch
            {
                PutContainersSettingsRequestCdnRegionProvider.Aws => "aws",
                PutContainersSettingsRequestCdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutContainersSettingsRequestCdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => PutContainersSettingsRequestCdnRegionProvider.Aws,
                "gcp" => PutContainersSettingsRequestCdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}