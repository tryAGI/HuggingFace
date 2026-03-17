
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseGrantType
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_ietf_params_oauth_grantType_tokenExchange,
        /// <summary>
        /// 
        /// </summary>
        Urn_ietf_params_oauth_grantType_deviceCode,
        /// <summary>
        /// 
        /// </summary>
        AuthorizationCode,
        /// <summary>
        /// 
        /// </summary>
        RefreshToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseGrantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseGrantType value)
        {
            return value switch
            {
                ResponseGrantType.Urn_ietf_params_oauth_grantType_tokenExchange => "urn:ietf:params:oauth:grant-type:token-exchange",
                ResponseGrantType.Urn_ietf_params_oauth_grantType_deviceCode => "urn:ietf:params:oauth:grant-type:device_code",
                ResponseGrantType.AuthorizationCode => "authorization_code",
                ResponseGrantType.RefreshToken => "refresh_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseGrantType? ToEnum(string value)
        {
            return value switch
            {
                "urn:ietf:params:oauth:grant-type:token-exchange" => ResponseGrantType.Urn_ietf_params_oauth_grantType_tokenExchange,
                "urn:ietf:params:oauth:grant-type:device_code" => ResponseGrantType.Urn_ietf_params_oauth_grantType_deviceCode,
                "authorization_code" => ResponseGrantType.AuthorizationCode,
                "refresh_token" => ResponseGrantType.RefreshToken,
                _ => null,
            };
        }
    }
}