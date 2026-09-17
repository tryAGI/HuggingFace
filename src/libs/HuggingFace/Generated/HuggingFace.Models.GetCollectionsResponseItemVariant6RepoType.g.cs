
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCollectionsResponseItemVariant6RepoType
    {
        /// <summary>
        ///
        /// </summary>
        Bucket,
        /// <summary>
        ///
        /// </summary>
        Container,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCollectionsResponseItemVariant6RepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant6RepoType value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant6RepoType.Bucket => "bucket",
                GetCollectionsResponseItemVariant6RepoType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant6RepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetCollectionsResponseItemVariant6RepoType.Bucket,
                "container" => GetCollectionsResponseItemVariant6RepoType.Container,
                _ => null,
            };
        }
    }
}