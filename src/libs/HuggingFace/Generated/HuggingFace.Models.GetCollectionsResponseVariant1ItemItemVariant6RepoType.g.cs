
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant6RepoType
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
    public static class GetCollectionsResponseVariant1ItemItemVariant6RepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant6RepoType value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant6RepoType.Bucket => "bucket",
                GetCollectionsResponseVariant1ItemItemVariant6RepoType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant6RepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetCollectionsResponseVariant1ItemItemVariant6RepoType.Bucket,
                "container" => GetCollectionsResponseVariant1ItemItemVariant6RepoType.Container,
                _ => null,
            };
        }
    }
}