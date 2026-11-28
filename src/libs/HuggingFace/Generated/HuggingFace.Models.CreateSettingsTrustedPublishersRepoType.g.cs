
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSettingsTrustedPublishersRepoType
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
    public static class CreateSettingsTrustedPublishersRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsTrustedPublishersRepoType value)
        {
            return value switch
            {
                CreateSettingsTrustedPublishersRepoType.Buckets => "buckets",
                CreateSettingsTrustedPublishersRepoType.Containers => "containers",
                CreateSettingsTrustedPublishersRepoType.Datasets => "datasets",
                CreateSettingsTrustedPublishersRepoType.Kernels => "kernels",
                CreateSettingsTrustedPublishersRepoType.Models => "models",
                CreateSettingsTrustedPublishersRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsTrustedPublishersRepoType? ToEnum(string value)
        {
            return value switch
            {
                "buckets" => CreateSettingsTrustedPublishersRepoType.Buckets,
                "containers" => CreateSettingsTrustedPublishersRepoType.Containers,
                "datasets" => CreateSettingsTrustedPublishersRepoType.Datasets,
                "kernels" => CreateSettingsTrustedPublishersRepoType.Kernels,
                "models" => CreateSettingsTrustedPublishersRepoType.Models,
                "spaces" => CreateSettingsTrustedPublishersRepoType.Spaces,
                _ => null,
            };
        }
    }
}