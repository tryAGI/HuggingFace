
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsCancelResponseOwnerType
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
    public static class CreateJobsCancelResponseOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsCancelResponseOwnerType value)
        {
            return value switch
            {
                CreateJobsCancelResponseOwnerType.Org => "org",
                CreateJobsCancelResponseOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsCancelResponseOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateJobsCancelResponseOwnerType.Org,
                "user" => CreateJobsCancelResponseOwnerType.User,
                _ => null,
            };
        }
    }
}