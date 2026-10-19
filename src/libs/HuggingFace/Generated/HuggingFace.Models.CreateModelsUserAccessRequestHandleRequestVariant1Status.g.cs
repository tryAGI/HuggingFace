
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateModelsUserAccessRequestHandleRequestVariant1Status
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
    public static class CreateModelsUserAccessRequestHandleRequestVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsUserAccessRequestHandleRequestVariant1Status value)
        {
            return value switch
            {
                CreateModelsUserAccessRequestHandleRequestVariant1Status.Accepted => "accepted",
                CreateModelsUserAccessRequestHandleRequestVariant1Status.Pending => "pending",
                CreateModelsUserAccessRequestHandleRequestVariant1Status.Rejected => "rejected",
                CreateModelsUserAccessRequestHandleRequestVariant1Status.Reset => "reset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsUserAccessRequestHandleRequestVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => CreateModelsUserAccessRequestHandleRequestVariant1Status.Accepted,
                "pending" => CreateModelsUserAccessRequestHandleRequestVariant1Status.Pending,
                "rejected" => CreateModelsUserAccessRequestHandleRequestVariant1Status.Rejected,
                "reset" => CreateModelsUserAccessRequestHandleRequestVariant1Status.Reset,
                _ => null,
            };
        }
    }
}