
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetsUserAccessRequestResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantedBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1, global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1, global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant2>? GrantedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetDatasetsUserAccessRequestResponseItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDatasetsUserAccessRequestResponseItemStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.Dictionary<string, string>? Fields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetsUserAccessRequestResponseItem" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="grantedBy"></param>
        /// <param name="status"></param>
        /// <param name="fields"></param>
        /// <param name="timestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDatasetsUserAccessRequestResponseItem(
            global::HuggingFace.GetDatasetsUserAccessRequestResponseItemStatus status,
            global::System.DateTime timestamp,
            global::HuggingFace.GetDatasetsUserAccessRequestResponseItemUser? user,
            global::HuggingFace.AnyOf<global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1, global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant2>? grantedBy,
            global::System.Collections.Generic.Dictionary<string, string>? fields)
        {
            this.Status = status;
            this.Timestamp = timestamp;
            this.User = user;
            this.GrantedBy = grantedBy;
            this.Fields = fields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetsUserAccessRequestResponseItem" /> class.
        /// </summary>
        public GetDatasetsUserAccessRequestResponseItem()
        {
        }
    }
}