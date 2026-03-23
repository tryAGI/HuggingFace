
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsResponseHfTokenTokenRole
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
    public static class GetJobsResponseHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsResponseHfTokenTokenRole value)
        {
            return value switch
            {
                GetJobsResponseHfTokenTokenRole.FineGrained => "fineGrained",
                GetJobsResponseHfTokenTokenRole.Read => "read",
                GetJobsResponseHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsResponseHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => GetJobsResponseHfTokenTokenRole.FineGrained,
                "read" => GetJobsResponseHfTokenTokenRole.Read,
                "write" => GetJobsResponseHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}