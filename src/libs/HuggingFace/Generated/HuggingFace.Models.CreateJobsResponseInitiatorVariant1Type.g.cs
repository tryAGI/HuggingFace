
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsResponseInitiatorVariant1Type
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
    public static class CreateJobsResponseInitiatorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsResponseInitiatorVariant1Type value)
        {
            return value switch
            {
                CreateJobsResponseInitiatorVariant1Type.Org => "org",
                CreateJobsResponseInitiatorVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsResponseInitiatorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateJobsResponseInitiatorVariant1Type.Org,
                "user" => CreateJobsResponseInitiatorVariant1Type.User,
                _ => null,
            };
        }
    }
}