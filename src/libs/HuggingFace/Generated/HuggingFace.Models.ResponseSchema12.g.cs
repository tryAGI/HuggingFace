
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseSchema12
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_ietf_params_scim_schemas_core_20_User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSchema12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSchema12 value)
        {
            return value switch
            {
                ResponseSchema12.Urn_ietf_params_scim_schemas_core_20_User => "urn:ietf:params:scim:schemas:core:2.0:User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSchema12? ToEnum(string value)
        {
            return value switch
            {
                "urn:ietf:params:scim:schemas:core:2.0:User" => ResponseSchema12.Urn_ietf_params_scim_schemas_core_20_User,
                _ => null,
            };
        }
    }
}