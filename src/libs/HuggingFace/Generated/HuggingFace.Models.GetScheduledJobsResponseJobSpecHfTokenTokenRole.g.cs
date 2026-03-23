
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScheduledJobsResponseJobSpecHfTokenTokenRole
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
    public static class GetScheduledJobsResponseJobSpecHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScheduledJobsResponseJobSpecHfTokenTokenRole value)
        {
            return value switch
            {
                GetScheduledJobsResponseJobSpecHfTokenTokenRole.FineGrained => "fineGrained",
                GetScheduledJobsResponseJobSpecHfTokenTokenRole.Read => "read",
                GetScheduledJobsResponseJobSpecHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScheduledJobsResponseJobSpecHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => GetScheduledJobsResponseJobSpecHfTokenTokenRole.FineGrained,
                "read" => GetScheduledJobsResponseJobSpecHfTokenTokenRole.Read,
                "write" => GetScheduledJobsResponseJobSpecHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}