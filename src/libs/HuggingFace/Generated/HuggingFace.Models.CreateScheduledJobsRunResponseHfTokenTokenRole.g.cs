
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsRunResponseHfTokenTokenRole
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
    public static class CreateScheduledJobsRunResponseHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsRunResponseHfTokenTokenRole value)
        {
            return value switch
            {
                CreateScheduledJobsRunResponseHfTokenTokenRole.FineGrained => "fineGrained",
                CreateScheduledJobsRunResponseHfTokenTokenRole.Read => "read",
                CreateScheduledJobsRunResponseHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsRunResponseHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => CreateScheduledJobsRunResponseHfTokenTokenRole.FineGrained,
                "read" => CreateScheduledJobsRunResponseHfTokenTokenRole.Read,
                "write" => CreateScheduledJobsRunResponseHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}