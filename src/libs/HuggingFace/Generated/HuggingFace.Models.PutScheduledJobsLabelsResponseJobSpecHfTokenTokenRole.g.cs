
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutScheduledJobsLabelsResponseJobSpecHfTokenTokenRole
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
    public static class PutScheduledJobsLabelsResponseJobSpecHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutScheduledJobsLabelsResponseJobSpecHfTokenTokenRole value)
        {
            return value switch
            {
                PutScheduledJobsLabelsResponseJobSpecHfTokenTokenRole.FineGrained => "fineGrained",
                PutScheduledJobsLabelsResponseJobSpecHfTokenTokenRole.Read => "read",
                PutScheduledJobsLabelsResponseJobSpecHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutScheduledJobsLabelsResponseJobSpecHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => PutScheduledJobsLabelsResponseJobSpecHfTokenTokenRole.FineGrained,
                "read" => PutScheduledJobsLabelsResponseJobSpecHfTokenTokenRole.Read,
                "write" => PutScheduledJobsLabelsResponseJobSpecHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}