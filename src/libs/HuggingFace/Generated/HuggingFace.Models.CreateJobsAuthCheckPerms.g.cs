
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsAuthCheckPerms
    {
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
    public static class CreateJobsAuthCheckPermsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsAuthCheckPerms value)
        {
            return value switch
            {
                CreateJobsAuthCheckPerms.Read => "read",
                CreateJobsAuthCheckPerms.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsAuthCheckPerms? ToEnum(string value)
        {
            return value switch
            {
                "read" => CreateJobsAuthCheckPerms.Read,
                "write" => CreateJobsAuthCheckPerms.Write,
                _ => null,
            };
        }
    }
}