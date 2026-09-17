
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant6RepoType2
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
    public static class PatchCollectionsResponseDataItemVariant6RepoType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant6RepoType2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant6RepoType2.Bucket => "bucket",
                PatchCollectionsResponseDataItemVariant6RepoType2.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant6RepoType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchCollectionsResponseDataItemVariant6RepoType2.Bucket,
                "container" => PatchCollectionsResponseDataItemVariant6RepoType2.Container,
                _ => null,
            };
        }
    }
}