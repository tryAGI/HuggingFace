
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOauthRegisterRequestTokenEndpointAuthMethod
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
    public static class CreateOauthRegisterRequestTokenEndpointAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOauthRegisterRequestTokenEndpointAuthMethod value)
        {
            return value switch
            {
                CreateOauthRegisterRequestTokenEndpointAuthMethod.ClientSecretBasic => "client_secret_basic",
                CreateOauthRegisterRequestTokenEndpointAuthMethod.ClientSecretPost => "client_secret_post",
                CreateOauthRegisterRequestTokenEndpointAuthMethod.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOauthRegisterRequestTokenEndpointAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => CreateOauthRegisterRequestTokenEndpointAuthMethod.ClientSecretBasic,
                "client_secret_post" => CreateOauthRegisterRequestTokenEndpointAuthMethod.ClientSecretPost,
                "none" => CreateOauthRegisterRequestTokenEndpointAuthMethod.None,
                _ => null,
            };
        }
    }
}