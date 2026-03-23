
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsDuplicateResponseOwnerType
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
    public static class CreateJobsDuplicateResponseOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsDuplicateResponseOwnerType value)
        {
            return value switch
            {
                CreateJobsDuplicateResponseOwnerType.Org => "org",
                CreateJobsDuplicateResponseOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsDuplicateResponseOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateJobsDuplicateResponseOwnerType.Org,
                "user" => CreateJobsDuplicateResponseOwnerType.User,
                _ => null,
            };
        }
    }
}