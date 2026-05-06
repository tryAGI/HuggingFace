
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBucketsXetReadTokenResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("casUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CasUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Exp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBucketsXetReadTokenResponse" /> class.
        /// </summary>
        /// <param name="casUrl"></param>
        /// <param name="exp"></param>
        /// <param name="accessToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBucketsXetReadTokenResponse(
            string casUrl,
            double exp,
            string accessToken)
        {
            this.CasUrl = casUrl ?? throw new global::System.ArgumentNullException(nameof(casUrl));
            this.Exp = exp;
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBucketsXetReadTokenResponse" /> class.
        /// </summary>
        public GetBucketsXetReadTokenResponse()
        {
        }
    }
}