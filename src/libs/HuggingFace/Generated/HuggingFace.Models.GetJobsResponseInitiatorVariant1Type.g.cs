
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsResponseInitiatorVariant1Type
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
    public static class GetJobsResponseInitiatorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsResponseInitiatorVariant1Type value)
        {
            return value switch
            {
                GetJobsResponseInitiatorVariant1Type.Org => "org",
                GetJobsResponseInitiatorVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsResponseInitiatorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetJobsResponseInitiatorVariant1Type.Org,
                "user" => GetJobsResponseInitiatorVariant1Type.User,
                _ => null,
            };
        }
    }
}