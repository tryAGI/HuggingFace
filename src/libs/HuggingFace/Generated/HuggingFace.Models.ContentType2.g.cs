
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// `application/x-ndjson` if you to commit by json lines<br/>
    /// Default Value: application/x-ndjson
    /// </summary>
    public enum ContentType2
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
    public static class ContentType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentType2 value)
        {
            return value switch
            {
                ContentType2.ApplicationJson => "application/json",
                ContentType2.ApplicationXNdjson => "application/x-ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentType2? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => ContentType2.ApplicationJson,
                "application/x-ndjson" => ContentType2.ApplicationXNdjson,
                _ => null,
            };
        }
    }
}