
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsRunResponseInitiatorVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateScheduledJobsRunResponseInitiatorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsRunResponseInitiatorVariant1Type value)
        {
            return value switch
            {
                CreateScheduledJobsRunResponseInitiatorVariant1Type.Org => "org",
                CreateScheduledJobsRunResponseInitiatorVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsRunResponseInitiatorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateScheduledJobsRunResponseInitiatorVariant1Type.Org,
                "user" => CreateScheduledJobsRunResponseInitiatorVariant1Type.User,
                _ => null,
            };
        }
    }
}