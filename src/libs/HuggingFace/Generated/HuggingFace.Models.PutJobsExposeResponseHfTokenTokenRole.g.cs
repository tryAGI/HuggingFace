
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsExposeResponseHfTokenTokenRole
    {
        /// <summary>
        /// 
        /// </summary>
        FineGrained,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutJobsExposeResponseHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsExposeResponseHfTokenTokenRole value)
        {
            return value switch
            {
                PutJobsExposeResponseHfTokenTokenRole.FineGrained => "fineGrained",
                PutJobsExposeResponseHfTokenTokenRole.Read => "read",
                PutJobsExposeResponseHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsExposeResponseHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => PutJobsExposeResponseHfTokenTokenRole.FineGrained,
                "read" => PutJobsExposeResponseHfTokenTokenRole.Read,
                "write" => PutJobsExposeResponseHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}