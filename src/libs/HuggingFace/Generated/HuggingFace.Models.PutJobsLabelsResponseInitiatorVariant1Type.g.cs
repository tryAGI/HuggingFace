
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsLabelsResponseInitiatorVariant1Type
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
    public static class PutJobsLabelsResponseInitiatorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsLabelsResponseInitiatorVariant1Type value)
        {
            return value switch
            {
                PutJobsLabelsResponseInitiatorVariant1Type.Org => "org",
                PutJobsLabelsResponseInitiatorVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsLabelsResponseInitiatorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "org" => PutJobsLabelsResponseInitiatorVariant1Type.Org,
                "user" => PutJobsLabelsResponseInitiatorVariant1Type.User,
                _ => null,
            };
        }
    }
}