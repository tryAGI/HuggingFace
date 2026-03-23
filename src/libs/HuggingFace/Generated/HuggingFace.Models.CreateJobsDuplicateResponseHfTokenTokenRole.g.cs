
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsDuplicateResponseHfTokenTokenRole
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
    public static class CreateJobsDuplicateResponseHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsDuplicateResponseHfTokenTokenRole value)
        {
            return value switch
            {
                CreateJobsDuplicateResponseHfTokenTokenRole.FineGrained => "fineGrained",
                CreateJobsDuplicateResponseHfTokenTokenRole.Read => "read",
                CreateJobsDuplicateResponseHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsDuplicateResponseHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => CreateJobsDuplicateResponseHfTokenTokenRole.FineGrained,
                "read" => CreateJobsDuplicateResponseHfTokenTokenRole.Read,
                "write" => CreateJobsDuplicateResponseHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}