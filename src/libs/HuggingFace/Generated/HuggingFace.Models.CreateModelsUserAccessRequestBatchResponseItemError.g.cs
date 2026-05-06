
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsUserAccessRequestBatchResponseItemError
    {
        /// <summary>
        /// 
        /// </summary>
        RequestNotFound,
        /// <summary>
        /// 
        /// </summary>
        UserNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelsUserAccessRequestBatchResponseItemErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsUserAccessRequestBatchResponseItemError value)
        {
            return value switch
            {
                CreateModelsUserAccessRequestBatchResponseItemError.RequestNotFound => "request_not_found",
                CreateModelsUserAccessRequestBatchResponseItemError.UserNotFound => "user_not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsUserAccessRequestBatchResponseItemError? ToEnum(string value)
        {
            return value switch
            {
                "request_not_found" => CreateModelsUserAccessRequestBatchResponseItemError.RequestNotFound,
                "user_not_found" => CreateModelsUserAccessRequestBatchResponseItemError.UserNotFound,
                _ => null,
            };
        }
    }
}