
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutContainersSettingsResponseCdnRegionProvider
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
    public static class PutContainersSettingsResponseCdnRegionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutContainersSettingsResponseCdnRegionProvider value)
        {
            return value switch
            {
                PutContainersSettingsResponseCdnRegionProvider.Aws => "aws",
                PutContainersSettingsResponseCdnRegionProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutContainersSettingsResponseCdnRegionProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => PutContainersSettingsResponseCdnRegionProvider.Aws,
                "gcp" => PutContainersSettingsResponseCdnRegionProvider.Gcp,
                _ => null,
            };
        }
    }
}