
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateInferenceEndpointsAuthCheckPerms
    {
        /// <summary>
        /// 
        /// </summary>
        Infer,
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
    public static class CreateInferenceEndpointsAuthCheckPermsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateInferenceEndpointsAuthCheckPerms value)
        {
            return value switch
            {
                CreateInferenceEndpointsAuthCheckPerms.Infer => "infer",
                CreateInferenceEndpointsAuthCheckPerms.Read => "read",
                CreateInferenceEndpointsAuthCheckPerms.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateInferenceEndpointsAuthCheckPerms? ToEnum(string value)
        {
            return value switch
            {
                "infer" => CreateInferenceEndpointsAuthCheckPerms.Infer,
                "read" => CreateInferenceEndpointsAuthCheckPerms.Read,
                "write" => CreateInferenceEndpointsAuthCheckPerms.Write,
                _ => null,
            };
        }
    }
}