
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsAuthCheckPerms2
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
    public static class CreateJobsAuthCheckPerms2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsAuthCheckPerms2 value)
        {
            return value switch
            {
                CreateJobsAuthCheckPerms2.Read => "read",
                CreateJobsAuthCheckPerms2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsAuthCheckPerms2? ToEnum(string value)
        {
            return value switch
            {
                "read" => CreateJobsAuthCheckPerms2.Read,
                "write" => CreateJobsAuthCheckPerms2.Write,
                _ => null,
            };
        }
    }
}