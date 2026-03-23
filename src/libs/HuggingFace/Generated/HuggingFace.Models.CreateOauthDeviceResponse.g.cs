
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOauthDeviceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeviceCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VerificationUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpiresIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOauthDeviceResponse" /> class.
        /// </summary>
        /// <param name="deviceCode"></param>
        /// <param name="userCode"></param>
        /// <param name="verificationUri"></param>
        /// <param name="expiresIn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOauthDeviceResponse(
            string deviceCode,
            string userCode,
            string verificationUri,
            double expiresIn)
        {
            this.DeviceCode = deviceCode ?? throw new global::System.ArgumentNullException(nameof(deviceCode));
            this.UserCode = userCode ?? throw new global::System.ArgumentNullException(nameof(userCode));
            this.VerificationUri = verificationUri ?? throw new global::System.ArgumentNullException(nameof(verificationUri));
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOauthDeviceResponse" /> class.
        /// </summary>
        public CreateOauthDeviceResponse()
        {
        }
    }
}