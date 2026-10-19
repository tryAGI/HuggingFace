
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateModelsUserAccessRequestHandleRequestVariant2Status
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
    public static class CreateModelsUserAccessRequestHandleRequestVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsUserAccessRequestHandleRequestVariant2Status value)
        {
            return value switch
            {
                CreateModelsUserAccessRequestHandleRequestVariant2Status.Accepted => "accepted",
                CreateModelsUserAccessRequestHandleRequestVariant2Status.Pending => "pending",
                CreateModelsUserAccessRequestHandleRequestVariant2Status.Rejected => "rejected",
                CreateModelsUserAccessRequestHandleRequestVariant2Status.Reset => "reset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsUserAccessRequestHandleRequestVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => CreateModelsUserAccessRequestHandleRequestVariant2Status.Accepted,
                "pending" => CreateModelsUserAccessRequestHandleRequestVariant2Status.Pending,
                "rejected" => CreateModelsUserAccessRequestHandleRequestVariant2Status.Rejected,
                "reset" => CreateModelsUserAccessRequestHandleRequestVariant2Status.Reset,
                _ => null,
            };
        }
    }
}