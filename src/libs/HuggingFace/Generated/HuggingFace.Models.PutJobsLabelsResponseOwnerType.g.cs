
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsLabelsResponseOwnerType
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
    public static class PutJobsLabelsResponseOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsLabelsResponseOwnerType value)
        {
            return value switch
            {
                PutJobsLabelsResponseOwnerType.Org => "org",
                PutJobsLabelsResponseOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsLabelsResponseOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => PutJobsLabelsResponseOwnerType.Org,
                "user" => PutJobsLabelsResponseOwnerType.User,
                _ => null,
            };
        }
    }
}