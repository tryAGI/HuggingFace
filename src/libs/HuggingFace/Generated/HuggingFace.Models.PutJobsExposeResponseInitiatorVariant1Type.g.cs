
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsExposeResponseInitiatorVariant1Type
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
    public static class PutJobsExposeResponseInitiatorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsExposeResponseInitiatorVariant1Type value)
        {
            return value switch
            {
                PutJobsExposeResponseInitiatorVariant1Type.Org => "org",
                PutJobsExposeResponseInitiatorVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsExposeResponseInitiatorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "org" => PutJobsExposeResponseInitiatorVariant1Type.Org,
                "user" => PutJobsExposeResponseInitiatorVariant1Type.User,
                _ => null,
            };
        }
    }
}