
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteSettingsTrustedPublishersRepoType
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
    public static class DeleteSettingsTrustedPublishersRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteSettingsTrustedPublishersRepoType value)
        {
            return value switch
            {
                DeleteSettingsTrustedPublishersRepoType.Buckets => "buckets",
                DeleteSettingsTrustedPublishersRepoType.Containers => "containers",
                DeleteSettingsTrustedPublishersRepoType.Datasets => "datasets",
                DeleteSettingsTrustedPublishersRepoType.Kernels => "kernels",
                DeleteSettingsTrustedPublishersRepoType.Models => "models",
                DeleteSettingsTrustedPublishersRepoType.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteSettingsTrustedPublishersRepoType? ToEnum(string value)
        {
            return value switch
            {
                "buckets" => DeleteSettingsTrustedPublishersRepoType.Buckets,
                "containers" => DeleteSettingsTrustedPublishersRepoType.Containers,
                "datasets" => DeleteSettingsTrustedPublishersRepoType.Datasets,
                "kernels" => DeleteSettingsTrustedPublishersRepoType.Kernels,
                "models" => DeleteSettingsTrustedPublishersRepoType.Models,
                "spaces" => DeleteSettingsTrustedPublishersRepoType.Spaces,
                _ => null,
            };
        }
    }
}