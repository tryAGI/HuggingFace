
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseTokenEndpointAuthMethod
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
    public static class ResponseTokenEndpointAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTokenEndpointAuthMethod value)
        {
            return value switch
            {
                ResponseTokenEndpointAuthMethod.ClientSecretBasic => "client_secret_basic",
                ResponseTokenEndpointAuthMethod.None => "none",
                ResponseTokenEndpointAuthMethod.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTokenEndpointAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => ResponseTokenEndpointAuthMethod.ClientSecretBasic,
                "none" => ResponseTokenEndpointAuthMethod.None,
                "client_secret_post" => ResponseTokenEndpointAuthMethod.ClientSecretPost,
                _ => null,
            };
        }
    }
}