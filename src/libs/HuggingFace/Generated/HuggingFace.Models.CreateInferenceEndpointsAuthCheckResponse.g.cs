
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInferenceEndpointsAuthCheckResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseNamespace Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseUser User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInferenceEndpointsAuthCheckResponse" /> class.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInferenceEndpointsAuthCheckResponse(
            global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseNamespace @namespace,
            global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseUser user)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInferenceEndpointsAuthCheckResponse" /> class.
        /// </summary>
        public CreateInferenceEndpointsAuthCheckResponse()
        {
        }
    }
}