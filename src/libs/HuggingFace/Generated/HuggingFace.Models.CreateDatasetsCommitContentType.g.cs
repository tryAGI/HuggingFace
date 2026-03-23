
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// `application/x-ndjson` if you to commit by json lines<br/>
    /// Default Value: application/x-ndjson
    /// </summary>
    public enum CreateDatasetsCommitContentType
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
    public static class CreateDatasetsCommitContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsCommitContentType value)
        {
            return value switch
            {
                CreateDatasetsCommitContentType.ApplicationJson => "application/json",
                CreateDatasetsCommitContentType.ApplicationXNdjson => "application/x-ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsCommitContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => CreateDatasetsCommitContentType.ApplicationJson,
                "application/x-ndjson" => CreateDatasetsCommitContentType.ApplicationXNdjson,
                _ => null,
            };
        }
    }
}