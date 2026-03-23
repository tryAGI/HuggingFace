
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsResponseItemOwnerType
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
    public static class GetJobsResponseItemOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsResponseItemOwnerType value)
        {
            return value switch
            {
                GetJobsResponseItemOwnerType.Org => "org",
                GetJobsResponseItemOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsResponseItemOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetJobsResponseItemOwnerType.Org,
                "user" => GetJobsResponseItemOwnerType.User,
                _ => null,
            };
        }
    }
}