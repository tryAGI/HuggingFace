
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOauthRegisterResponseTokenEndpointAuthMethod
    {
        /// <summary>
        /// 
        /// </summary>
        ClientSecretBasic,
        /// <summary>
        /// 
        /// </summary>
        ClientSecretPost,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOauthRegisterResponseTokenEndpointAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOauthRegisterResponseTokenEndpointAuthMethod value)
        {
            return value switch
            {
                CreateOauthRegisterResponseTokenEndpointAuthMethod.ClientSecretBasic => "client_secret_basic",
                CreateOauthRegisterResponseTokenEndpointAuthMethod.ClientSecretPost => "client_secret_post",
                CreateOauthRegisterResponseTokenEndpointAuthMethod.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOauthRegisterResponseTokenEndpointAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => CreateOauthRegisterResponseTokenEndpointAuthMethod.ClientSecretBasic,
                "client_secret_post" => CreateOauthRegisterResponseTokenEndpointAuthMethod.ClientSecretPost,
                "none" => CreateOauthRegisterResponseTokenEndpointAuthMethod.None,
                _ => null,
            };
        }
    }
}