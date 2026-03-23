
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOauthRegisterResponseGrantType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationCode,
        /// <summary>
        /// 
        /// </summary>
        RefreshToken,
        /// <summary>
        /// 
        /// </summary>
        Urn_ietf_params_oauth_grantType_deviceCode,
        /// <summary>
        /// 
        /// </summary>
        Urn_ietf_params_oauth_grantType_tokenExchange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOauthRegisterResponseGrantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOauthRegisterResponseGrantType value)
        {
            return value switch
            {
                CreateOauthRegisterResponseGrantType.AuthorizationCode => "authorization_code",
                CreateOauthRegisterResponseGrantType.RefreshToken => "refresh_token",
                CreateOauthRegisterResponseGrantType.Urn_ietf_params_oauth_grantType_deviceCode => "urn:ietf:params:oauth:grant-type:device_code",
                CreateOauthRegisterResponseGrantType.Urn_ietf_params_oauth_grantType_tokenExchange => "urn:ietf:params:oauth:grant-type:token-exchange",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOauthRegisterResponseGrantType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_code" => CreateOauthRegisterResponseGrantType.AuthorizationCode,
                "refresh_token" => CreateOauthRegisterResponseGrantType.RefreshToken,
                "urn:ietf:params:oauth:grant-type:device_code" => CreateOauthRegisterResponseGrantType.Urn_ietf_params_oauth_grantType_deviceCode,
                "urn:ietf:params:oauth:grant-type:token-exchange" => CreateOauthRegisterResponseGrantType.Urn_ietf_params_oauth_grantType_tokenExchange,
                _ => null,
            };
        }
    }
}