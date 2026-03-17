
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseSchema9
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_ietf_params_scim_schemas_core_20_Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSchema9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSchema9 value)
        {
            return value switch
            {
                ResponseSchema9.Urn_ietf_params_scim_schemas_core_20_Group => "urn:ietf:params:scim:schemas:core:2.0:Group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSchema9? ToEnum(string value)
        {
            return value switch
            {
                "urn:ietf:params:scim:schemas:core:2.0:Group" => ResponseSchema9.Urn_ietf_params_scim_schemas_core_20_Group,
                _ => null,
            };
        }
    }
}