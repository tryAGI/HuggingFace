
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Whether the repo is owned by a user or an organization
    /// </summary>
    public enum CreateQuicksearchResponseDatasetAuthorType
    {
        /// <summary>
        ///
        /// </summary>
        Org,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateQuicksearchResponseDatasetAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchResponseDatasetAuthorType value)
        {
            return value switch
            {
                CreateQuicksearchResponseDatasetAuthorType.Org => "org",
                CreateQuicksearchResponseDatasetAuthorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchResponseDatasetAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateQuicksearchResponseDatasetAuthorType.Org,
                "user" => CreateQuicksearchResponseDatasetAuthorType.User,
                _ => null,
            };
        }
    }
}