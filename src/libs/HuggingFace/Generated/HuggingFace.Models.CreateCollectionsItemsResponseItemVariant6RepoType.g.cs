
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant6RepoType
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
    public static class CreateCollectionsItemsResponseItemVariant6RepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant6RepoType value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant6RepoType.Bucket => "bucket",
                CreateCollectionsItemsResponseItemVariant6RepoType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant6RepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateCollectionsItemsResponseItemVariant6RepoType.Bucket,
                "container" => CreateCollectionsItemsResponseItemVariant6RepoType.Container,
                _ => null,
            };
        }
    }
}