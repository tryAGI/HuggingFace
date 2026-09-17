
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCollectionsResponseItemVariant6RepoType2
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
    public static class GetCollectionsResponseItemVariant6RepoType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant6RepoType2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant6RepoType2.Bucket => "bucket",
                GetCollectionsResponseItemVariant6RepoType2.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant6RepoType2? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetCollectionsResponseItemVariant6RepoType2.Bucket,
                "container" => GetCollectionsResponseItemVariant6RepoType2.Container,
                _ => null,
            };
        }
    }
}