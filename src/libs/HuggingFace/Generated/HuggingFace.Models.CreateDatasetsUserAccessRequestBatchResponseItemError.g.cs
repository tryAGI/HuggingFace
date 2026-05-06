
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsUserAccessRequestBatchResponseItemError
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
    public static class CreateDatasetsUserAccessRequestBatchResponseItemErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsUserAccessRequestBatchResponseItemError value)
        {
            return value switch
            {
                CreateDatasetsUserAccessRequestBatchResponseItemError.RequestNotFound => "request_not_found",
                CreateDatasetsUserAccessRequestBatchResponseItemError.UserNotFound => "user_not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsUserAccessRequestBatchResponseItemError? ToEnum(string value)
        {
            return value switch
            {
                "request_not_found" => CreateDatasetsUserAccessRequestBatchResponseItemError.RequestNotFound,
                "user_not_found" => CreateDatasetsUserAccessRequestBatchResponseItemError.UserNotFound,
                _ => null,
            };
        }
    }
}