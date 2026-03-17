
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseSchema6
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_ietf_params_scim_api_messages_20_ListResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSchema6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSchema6 value)
        {
            return value switch
            {
                ResponseSchema6.Urn_ietf_params_scim_api_messages_20_ListResponse => "urn:ietf:params:scim:api:messages:2.0:ListResponse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSchema6? ToEnum(string value)
        {
            return value switch
            {
                "urn:ietf:params:scim:api:messages:2.0:ListResponse" => ResponseSchema6.Urn_ietf_params_scim_api_messages_20_ListResponse,
                _ => null,
            };
        }
    }
}