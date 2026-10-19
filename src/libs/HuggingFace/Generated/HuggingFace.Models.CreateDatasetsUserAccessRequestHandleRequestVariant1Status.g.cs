
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDatasetsUserAccessRequestHandleRequestVariant1Status
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
    public static class CreateDatasetsUserAccessRequestHandleRequestVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsUserAccessRequestHandleRequestVariant1Status value)
        {
            return value switch
            {
                CreateDatasetsUserAccessRequestHandleRequestVariant1Status.Accepted => "accepted",
                CreateDatasetsUserAccessRequestHandleRequestVariant1Status.Pending => "pending",
                CreateDatasetsUserAccessRequestHandleRequestVariant1Status.Rejected => "rejected",
                CreateDatasetsUserAccessRequestHandleRequestVariant1Status.Reset => "reset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsUserAccessRequestHandleRequestVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => CreateDatasetsUserAccessRequestHandleRequestVariant1Status.Accepted,
                "pending" => CreateDatasetsUserAccessRequestHandleRequestVariant1Status.Pending,
                "rejected" => CreateDatasetsUserAccessRequestHandleRequestVariant1Status.Rejected,
                "reset" => CreateDatasetsUserAccessRequestHandleRequestVariant1Status.Reset,
                _ => null,
            };
        }
    }
}