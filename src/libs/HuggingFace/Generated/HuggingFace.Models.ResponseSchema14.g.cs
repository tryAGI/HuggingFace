
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseSchema14
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_ietf_params_scim_schemas_core_20_User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSchema14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSchema14 value)
        {
            return value switch
            {
                ResponseSchema14.Urn_ietf_params_scim_schemas_core_20_User => "urn:ietf:params:scim:schemas:core:2.0:User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSchema14? ToEnum(string value)
        {
            return value switch
            {
                "urn:ietf:params:scim:schemas:core:2.0:User" => ResponseSchema14.Urn_ietf_params_scim_schemas_core_20_User,
                _ => null,
            };
        }
    }
}