
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: staging
    /// </summary>
    public enum CreatePartnersModelsRequestVariant1Status
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
    public static class CreatePartnersModelsRequestVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePartnersModelsRequestVariant1Status value)
        {
            return value switch
            {
                CreatePartnersModelsRequestVariant1Status.Error => "error",
                CreatePartnersModelsRequestVariant1Status.Live => "live",
                CreatePartnersModelsRequestVariant1Status.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePartnersModelsRequestVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreatePartnersModelsRequestVariant1Status.Error,
                "live" => CreatePartnersModelsRequestVariant1Status.Live,
                "staging" => CreatePartnersModelsRequestVariant1Status.Staging,
                _ => null,
            };
        }
    }
}