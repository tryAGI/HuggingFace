
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsDuplicateResponseInitiatorVariant1Type
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
    public static class CreateJobsDuplicateResponseInitiatorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsDuplicateResponseInitiatorVariant1Type value)
        {
            return value switch
            {
                CreateJobsDuplicateResponseInitiatorVariant1Type.Org => "org",
                CreateJobsDuplicateResponseInitiatorVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsDuplicateResponseInitiatorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateJobsDuplicateResponseInitiatorVariant1Type.Org,
                "user" => CreateJobsDuplicateResponseInitiatorVariant1Type.User,
                _ => null,
            };
        }
    }
}