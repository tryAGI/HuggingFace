
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDatasetsUserAccessRequestHandleRequestVariant3Status
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
    public static class CreateDatasetsUserAccessRequestHandleRequestVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsUserAccessRequestHandleRequestVariant3Status value)
        {
            return value switch
            {
                CreateDatasetsUserAccessRequestHandleRequestVariant3Status.Accepted => "accepted",
                CreateDatasetsUserAccessRequestHandleRequestVariant3Status.Pending => "pending",
                CreateDatasetsUserAccessRequestHandleRequestVariant3Status.Rejected => "rejected",
                CreateDatasetsUserAccessRequestHandleRequestVariant3Status.Reset => "reset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsUserAccessRequestHandleRequestVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => CreateDatasetsUserAccessRequestHandleRequestVariant3Status.Accepted,
                "pending" => CreateDatasetsUserAccessRequestHandleRequestVariant3Status.Pending,
                "rejected" => CreateDatasetsUserAccessRequestHandleRequestVariant3Status.Rejected,
                "reset" => CreateDatasetsUserAccessRequestHandleRequestVariant3Status.Reset,
                _ => null,
            };
        }
    }
}