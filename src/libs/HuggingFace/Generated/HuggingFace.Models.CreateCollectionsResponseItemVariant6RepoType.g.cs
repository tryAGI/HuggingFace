
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCollectionsResponseItemVariant6RepoType
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
    public static class CreateCollectionsResponseItemVariant6RepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant6RepoType value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant6RepoType.Bucket => "bucket",
                CreateCollectionsResponseItemVariant6RepoType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant6RepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateCollectionsResponseItemVariant6RepoType.Bucket,
                "container" => CreateCollectionsResponseItemVariant6RepoType.Container,
                _ => null,
            };
        }
    }
}