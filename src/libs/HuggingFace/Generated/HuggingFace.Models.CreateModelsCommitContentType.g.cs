
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// `application/x-ndjson` if you to commit by json lines<br/>
    /// Default Value: application/x-ndjson
    /// </summary>
    public enum CreateModelsCommitContentType
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
    public static class CreateModelsCommitContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsCommitContentType value)
        {
            return value switch
            {
                CreateModelsCommitContentType.ApplicationJson => "application/json",
                CreateModelsCommitContentType.ApplicationXNdjson => "application/x-ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsCommitContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => CreateModelsCommitContentType.ApplicationJson,
                "application/x-ndjson" => CreateModelsCommitContentType.ApplicationXNdjson,
                _ => null,
            };
        }
    }
}