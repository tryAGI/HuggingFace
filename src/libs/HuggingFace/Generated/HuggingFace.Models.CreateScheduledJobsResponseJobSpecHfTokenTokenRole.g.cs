
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsResponseJobSpecHfTokenTokenRole
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
    public static class CreateScheduledJobsResponseJobSpecHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsResponseJobSpecHfTokenTokenRole value)
        {
            return value switch
            {
                CreateScheduledJobsResponseJobSpecHfTokenTokenRole.FineGrained => "fineGrained",
                CreateScheduledJobsResponseJobSpecHfTokenTokenRole.Read => "read",
                CreateScheduledJobsResponseJobSpecHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsResponseJobSpecHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => CreateScheduledJobsResponseJobSpecHfTokenTokenRole.FineGrained,
                "read" => CreateScheduledJobsResponseJobSpecHfTokenTokenRole.Read,
                "write" => CreateScheduledJobsResponseJobSpecHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}