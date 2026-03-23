
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsResponseHfTokenTokenRole
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
    public static class CreateJobsResponseHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsResponseHfTokenTokenRole value)
        {
            return value switch
            {
                CreateJobsResponseHfTokenTokenRole.FineGrained => "fineGrained",
                CreateJobsResponseHfTokenTokenRole.Read => "read",
                CreateJobsResponseHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsResponseHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => CreateJobsResponseHfTokenTokenRole.FineGrained,
                "read" => CreateJobsResponseHfTokenTokenRole.Read,
                "write" => CreateJobsResponseHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}