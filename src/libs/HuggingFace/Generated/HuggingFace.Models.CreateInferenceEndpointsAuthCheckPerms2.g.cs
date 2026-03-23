
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateInferenceEndpointsAuthCheckPerms2
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
    public static class CreateInferenceEndpointsAuthCheckPerms2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateInferenceEndpointsAuthCheckPerms2 value)
        {
            return value switch
            {
                CreateInferenceEndpointsAuthCheckPerms2.Infer => "infer",
                CreateInferenceEndpointsAuthCheckPerms2.Read => "read",
                CreateInferenceEndpointsAuthCheckPerms2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateInferenceEndpointsAuthCheckPerms2? ToEnum(string value)
        {
            return value switch
            {
                "infer" => CreateInferenceEndpointsAuthCheckPerms2.Infer,
                "read" => CreateInferenceEndpointsAuthCheckPerms2.Read,
                "write" => CreateInferenceEndpointsAuthCheckPerms2.Write,
                _ => null,
            };
        }
    }
}