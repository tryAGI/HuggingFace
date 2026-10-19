
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDatasetsUserAccessRequestHandleRequestVariant2Status
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
    public static class CreateDatasetsUserAccessRequestHandleRequestVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsUserAccessRequestHandleRequestVariant2Status value)
        {
            return value switch
            {
                CreateDatasetsUserAccessRequestHandleRequestVariant2Status.Accepted => "accepted",
                CreateDatasetsUserAccessRequestHandleRequestVariant2Status.Pending => "pending",
                CreateDatasetsUserAccessRequestHandleRequestVariant2Status.Rejected => "rejected",
                CreateDatasetsUserAccessRequestHandleRequestVariant2Status.Reset => "reset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsUserAccessRequestHandleRequestVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => CreateDatasetsUserAccessRequestHandleRequestVariant2Status.Accepted,
                "pending" => CreateDatasetsUserAccessRequestHandleRequestVariant2Status.Pending,
                "rejected" => CreateDatasetsUserAccessRequestHandleRequestVariant2Status.Rejected,
                "reset" => CreateDatasetsUserAccessRequestHandleRequestVariant2Status.Reset,
                _ => null,
            };
        }
    }
}