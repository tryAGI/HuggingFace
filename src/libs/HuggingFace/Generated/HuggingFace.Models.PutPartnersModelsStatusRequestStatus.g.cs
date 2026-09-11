
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PutPartnersModelsStatusRequestStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Live,
        /// <summary>
        ///
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutPartnersModelsStatusRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutPartnersModelsStatusRequestStatus value)
        {
            return value switch
            {
                PutPartnersModelsStatusRequestStatus.Error => "error",
                PutPartnersModelsStatusRequestStatus.Live => "live",
                PutPartnersModelsStatusRequestStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutPartnersModelsStatusRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PutPartnersModelsStatusRequestStatus.Error,
                "live" => PutPartnersModelsStatusRequestStatus.Live,
                "staging" => PutPartnersModelsStatusRequestStatus.Staging,
                _ => null,
            };
        }
    }
}