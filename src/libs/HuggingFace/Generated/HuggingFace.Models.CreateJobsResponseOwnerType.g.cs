
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsResponseOwnerType
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
    public static class CreateJobsResponseOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsResponseOwnerType value)
        {
            return value switch
            {
                CreateJobsResponseOwnerType.Org => "org",
                CreateJobsResponseOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsResponseOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateJobsResponseOwnerType.Org,
                "user" => CreateJobsResponseOwnerType.User,
                _ => null,
            };
        }
    }
}