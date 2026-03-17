
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemVariant3RuntimeDomain2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemVariant3RuntimeDomainStage2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemVariant3RuntimeDomainStage2 Stage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant3RuntimeDomain2" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="isCustom"></param>
        /// <param name="stage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemVariant3RuntimeDomain2(
            string domain,
            global::HuggingFace.ResponseItemVariant3RuntimeDomainStage2 stage,
            bool? isCustom)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Stage = stage;
            this.IsCustom = isCustom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemVariant3RuntimeDomain2" /> class.
        /// </summary>
        public ResponseItemVariant3RuntimeDomain2()
        {
        }
    }
}