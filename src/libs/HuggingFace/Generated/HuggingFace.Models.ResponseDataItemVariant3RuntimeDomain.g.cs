
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseDataItemVariant3RuntimeDomain
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCustom")]
        public bool? IsCustom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseDataItemVariant3RuntimeDomainStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseDataItemVariant3RuntimeDomainStage Stage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDataItemVariant3RuntimeDomain" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="isCustom"></param>
        /// <param name="stage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseDataItemVariant3RuntimeDomain(
            string domain,
            global::HuggingFace.ResponseDataItemVariant3RuntimeDomainStage stage,
            bool? isCustom)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Stage = stage;
            this.IsCustom = isCustom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDataItemVariant3RuntimeDomain" /> class.
        /// </summary>
        public ResponseDataItemVariant3RuntimeDomain()
        {
        }
    }
}