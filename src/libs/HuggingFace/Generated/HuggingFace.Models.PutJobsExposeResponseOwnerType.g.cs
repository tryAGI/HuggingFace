
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsExposeResponseOwnerType
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
    public static class PutJobsExposeResponseOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsExposeResponseOwnerType value)
        {
            return value switch
            {
                PutJobsExposeResponseOwnerType.Org => "org",
                PutJobsExposeResponseOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsExposeResponseOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => PutJobsExposeResponseOwnerType.Org,
                "user" => PutJobsExposeResponseOwnerType.User,
                _ => null,
            };
        }
    }
}