
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsCancelResponseInitiatorVariant1Type
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
    public static class CreateJobsCancelResponseInitiatorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsCancelResponseInitiatorVariant1Type value)
        {
            return value switch
            {
                CreateJobsCancelResponseInitiatorVariant1Type.Org => "org",
                CreateJobsCancelResponseInitiatorVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsCancelResponseInitiatorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateJobsCancelResponseInitiatorVariant1Type.Org,
                "user" => CreateJobsCancelResponseInitiatorVariant1Type.User,
                _ => null,
            };
        }
    }
}