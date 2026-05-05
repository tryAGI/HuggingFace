
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsLabelsResponseHfTokenTokenRole
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
    public static class PutJobsLabelsResponseHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsLabelsResponseHfTokenTokenRole value)
        {
            return value switch
            {
                PutJobsLabelsResponseHfTokenTokenRole.FineGrained => "fineGrained",
                PutJobsLabelsResponseHfTokenTokenRole.Read => "read",
                PutJobsLabelsResponseHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsLabelsResponseHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => PutJobsLabelsResponseHfTokenTokenRole.FineGrained,
                "read" => PutJobsLabelsResponseHfTokenTokenRole.Read,
                "write" => PutJobsLabelsResponseHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}