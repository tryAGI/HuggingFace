
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCollectionsResponseItemVariant3RuntimeHotReloading
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicaStatuses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> ReplicaStatuses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollectionsResponseItemVariant3RuntimeHotReloading" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="replicaStatuses"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCollectionsResponseItemVariant3RuntimeHotReloading(
            string status,
            global::System.Collections.Generic.IList<byte[]> replicaStatuses)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.ReplicaStatuses = replicaStatuses ?? throw new global::System.ArgumentNullException(nameof(replicaStatuses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollectionsResponseItemVariant3RuntimeHotReloading" /> class.
        /// </summary>
        public GetCollectionsResponseItemVariant3RuntimeHotReloading()
        {
        }
    }
}