
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsResponseItemHfTokenTokenRole
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
    public static class GetJobsResponseItemHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsResponseItemHfTokenTokenRole value)
        {
            return value switch
            {
                GetJobsResponseItemHfTokenTokenRole.FineGrained => "fineGrained",
                GetJobsResponseItemHfTokenTokenRole.Read => "read",
                GetJobsResponseItemHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsResponseItemHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => GetJobsResponseItemHfTokenTokenRole.FineGrained,
                "read" => GetJobsResponseItemHfTokenTokenRole.Read,
                "write" => GetJobsResponseItemHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}