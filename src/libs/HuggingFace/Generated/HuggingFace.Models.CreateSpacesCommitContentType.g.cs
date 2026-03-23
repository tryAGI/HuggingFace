
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// `application/x-ndjson` if you to commit by json lines<br/>
    /// Default Value: application/x-ndjson
    /// </summary>
    public enum CreateSpacesCommitContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationJson,
        /// <summary>
        /// 
        /// </summary>
        ApplicationXNdjson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpacesCommitContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesCommitContentType value)
        {
            return value switch
            {
                CreateSpacesCommitContentType.ApplicationJson => "application/json",
                CreateSpacesCommitContentType.ApplicationXNdjson => "application/x-ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesCommitContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => CreateSpacesCommitContentType.ApplicationJson,
                "application/x-ndjson" => CreateSpacesCommitContentType.ApplicationXNdjson,
                _ => null,
            };
        }
    }
}