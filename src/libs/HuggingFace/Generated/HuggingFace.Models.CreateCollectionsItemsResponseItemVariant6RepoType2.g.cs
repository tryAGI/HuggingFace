
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant6RepoType2
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
    public static class CreateCollectionsItemsResponseItemVariant6RepoType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant6RepoType2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant6RepoType2.Bucket => "bucket",
                CreateCollectionsItemsResponseItemVariant6RepoType2.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant6RepoType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateCollectionsItemsResponseItemVariant6RepoType2.Bucket,
                "container" => CreateCollectionsItemsResponseItemVariant6RepoType2.Container,
                _ => null,
            };
        }
    }
}