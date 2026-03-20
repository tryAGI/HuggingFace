
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestTokenEndpointAuthMethod
    {
        /// <summary>
        /// 
        /// </summary>
        ClientSecretBasic,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        ClientSecretPost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestTokenEndpointAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTokenEndpointAuthMethod value)
        {
            return value switch
            {
                RequestTokenEndpointAuthMethod.ClientSecretBasic => "client_secret_basic",
                RequestTokenEndpointAuthMethod.None => "none",
                RequestTokenEndpointAuthMethod.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTokenEndpointAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => RequestTokenEndpointAuthMethod.ClientSecretBasic,
                "none" => RequestTokenEndpointAuthMethod.None,
                "client_secret_post" => RequestTokenEndpointAuthMethod.ClientSecretPost,
                _ => null,
            };
        }
    }
}