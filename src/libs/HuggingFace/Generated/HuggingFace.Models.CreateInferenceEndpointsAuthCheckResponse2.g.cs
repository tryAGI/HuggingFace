
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInferenceEndpointsAuthCheckResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseNamespace2 Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseUser2 User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patternRestrictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PatternRestrictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInferenceEndpointsAuthCheckResponse2" /> class.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="user"></param>
        /// <param name="patternRestrictions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInferenceEndpointsAuthCheckResponse2(
            global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseNamespace2 @namespace,
            global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseUser2 user,
            global::System.Collections.Generic.IList<string> patternRestrictions)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.PatternRestrictions = patternRestrictions ?? throw new global::System.ArgumentNullException(nameof(patternRestrictions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInferenceEndpointsAuthCheckResponse2" /> class.
        /// </summary>
        public CreateInferenceEndpointsAuthCheckResponse2()
        {
        }
    }
}