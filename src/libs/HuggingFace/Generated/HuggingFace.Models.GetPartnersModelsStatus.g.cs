
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPartnersModelsStatus
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
    public static class GetPartnersModelsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPartnersModelsStatus value)
        {
            return value switch
            {
                GetPartnersModelsStatus.Error => "error",
                GetPartnersModelsStatus.Live => "live",
                GetPartnersModelsStatus.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPartnersModelsStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetPartnersModelsStatus.Error,
                "live" => GetPartnersModelsStatus.Live,
                "staging" => GetPartnersModelsStatus.Staging,
                _ => null,
            };
        }
    }
}