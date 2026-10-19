
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateModelsUserAccessRequestHandleRequestVariant3Status
    {
        /// <summary>
        ///
        /// </summary>
        Accepted,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Rejected,
        /// <summary>
        ///
        /// </summary>
        Reset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelsUserAccessRequestHandleRequestVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsUserAccessRequestHandleRequestVariant3Status value)
        {
            return value switch
            {
                CreateModelsUserAccessRequestHandleRequestVariant3Status.Accepted => "accepted",
                CreateModelsUserAccessRequestHandleRequestVariant3Status.Pending => "pending",
                CreateModelsUserAccessRequestHandleRequestVariant3Status.Rejected => "rejected",
                CreateModelsUserAccessRequestHandleRequestVariant3Status.Reset => "reset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsUserAccessRequestHandleRequestVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => CreateModelsUserAccessRequestHandleRequestVariant3Status.Accepted,
                "pending" => CreateModelsUserAccessRequestHandleRequestVariant3Status.Pending,
                "rejected" => CreateModelsUserAccessRequestHandleRequestVariant3Status.Rejected,
                "reset" => CreateModelsUserAccessRequestHandleRequestVariant3Status.Reset,
                _ => null,
            };
        }
    }
}