
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsCancelResponseHfTokenTokenRole
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
    public static class CreateJobsCancelResponseHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsCancelResponseHfTokenTokenRole value)
        {
            return value switch
            {
                CreateJobsCancelResponseHfTokenTokenRole.FineGrained => "fineGrained",
                CreateJobsCancelResponseHfTokenTokenRole.Read => "read",
                CreateJobsCancelResponseHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsCancelResponseHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => CreateJobsCancelResponseHfTokenTokenRole.FineGrained,
                "read" => CreateJobsCancelResponseHfTokenTokenRole.Read,
                "write" => CreateJobsCancelResponseHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}