
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant6RepoType
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
    public static class PatchCollectionsResponseDataItemVariant6RepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant6RepoType value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant6RepoType.Bucket => "bucket",
                PatchCollectionsResponseDataItemVariant6RepoType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant6RepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchCollectionsResponseDataItemVariant6RepoType.Bucket,
                "container" => PatchCollectionsResponseDataItemVariant6RepoType.Container,
                _ => null,
            };
        }
    }
}