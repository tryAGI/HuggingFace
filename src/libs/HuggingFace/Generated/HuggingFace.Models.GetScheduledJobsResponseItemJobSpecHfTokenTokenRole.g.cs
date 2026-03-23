
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScheduledJobsResponseItemJobSpecHfTokenTokenRole
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
    public static class GetScheduledJobsResponseItemJobSpecHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScheduledJobsResponseItemJobSpecHfTokenTokenRole value)
        {
            return value switch
            {
                GetScheduledJobsResponseItemJobSpecHfTokenTokenRole.FineGrained => "fineGrained",
                GetScheduledJobsResponseItemJobSpecHfTokenTokenRole.Read => "read",
                GetScheduledJobsResponseItemJobSpecHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScheduledJobsResponseItemJobSpecHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => GetScheduledJobsResponseItemJobSpecHfTokenTokenRole.FineGrained,
                "read" => GetScheduledJobsResponseItemJobSpecHfTokenTokenRole.Read,
                "write" => GetScheduledJobsResponseItemJobSpecHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}