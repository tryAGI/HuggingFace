
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSettingsTrustedPublishersRepoType
    {
        /// <summary>
        ///
        /// </summary>
        Buckets,
        /// <summary>
        ///
        /// </summary>
        Containers,
        /// <summary>
        ///
        /// </summary>
        Datasets,
        /// <summary>
        ///
        /// </summary>
        Kernels,
        /// <summary>
        ///
        /// </summary>
        Models,
        /// <summary>
        ///
        /// </summary>
        Spaces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSettingsTrustedPublishersRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsTrustedPublishersRepoType value)
        {
            return value switch
            {
                GetSettingsTrustedPublishersRepoType.Buckets => "buckets",
                GetSettingsTrustedPublishersRepoType.Containers => "containers",
                GetSettingsTrustedPublishersRepoType.Datasets => "datasets",
                GetSettingsTrustedPublishersRepoType.Kernels => "kernels",
                GetSettingsTrustedPublishersRepoType.Models => "models",
                GetSettingsTrustedPublishersRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsTrustedPublishersRepoType? ToEnum(string value)
        {
            return value switch
            {
                "buckets" => GetSettingsTrustedPublishersRepoType.Buckets,
                "containers" => GetSettingsTrustedPublishersRepoType.Containers,
                "datasets" => GetSettingsTrustedPublishersRepoType.Datasets,
                "kernels" => GetSettingsTrustedPublishersRepoType.Kernels,
                "models" => GetSettingsTrustedPublishersRepoType.Models,
                "spaces" => GetSettingsTrustedPublishersRepoType.Spaces,
                _ => null,
            };
        }
    }
}