
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: staging
    /// </summary>
    public enum CreatePartnersModelsRequestVariant2Status
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
    public static class CreatePartnersModelsRequestVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePartnersModelsRequestVariant2Status value)
        {
            return value switch
            {
                CreatePartnersModelsRequestVariant2Status.Error => "error",
                CreatePartnersModelsRequestVariant2Status.Live => "live",
                CreatePartnersModelsRequestVariant2Status.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePartnersModelsRequestVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreatePartnersModelsRequestVariant2Status.Error,
                "live" => CreatePartnersModelsRequestVariant2Status.Live,
                "staging" => CreatePartnersModelsRequestVariant2Status.Staging,
                _ => null,
            };
        }
    }
}