
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseSchema10
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_ietf_params_scim_schemas_core_20_Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSchema10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSchema10 value)
        {
            return value switch
            {
                ResponseSchema10.Urn_ietf_params_scim_schemas_core_20_Group => "urn:ietf:params:scim:schemas:core:2.0:Group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSchema10? ToEnum(string value)
        {
            return value switch
            {
                "urn:ietf:params:scim:schemas:core:2.0:Group" => ResponseSchema10.Urn_ietf_params_scim_schemas_core_20_Group,
                _ => null,
            };
        }
    }
}