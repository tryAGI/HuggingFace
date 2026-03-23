
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsResponseItemInitiatorVariant1Type
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
    public static class GetJobsResponseItemInitiatorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsResponseItemInitiatorVariant1Type value)
        {
            return value switch
            {
                GetJobsResponseItemInitiatorVariant1Type.Org => "org",
                GetJobsResponseItemInitiatorVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsResponseItemInitiatorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetJobsResponseItemInitiatorVariant1Type.Org,
                "user" => GetJobsResponseItemInitiatorVariant1Type.User,
                _ => null,
            };
        }
    }
}