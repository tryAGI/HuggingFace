
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseSchema11
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_ietf_params_scim_api_messages_20_ListResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSchema11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSchema11 value)
        {
            return value switch
            {
                ResponseSchema11.Urn_ietf_params_scim_api_messages_20_ListResponse => "urn:ietf:params:scim:api:messages:2.0:ListResponse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSchema11? ToEnum(string value)
        {
            return value switch
            {
                "urn:ietf:params:scim:api:messages:2.0:ListResponse" => ResponseSchema11.Urn_ietf_params_scim_api_messages_20_ListResponse,
                _ => null,
            };
        }
    }
}