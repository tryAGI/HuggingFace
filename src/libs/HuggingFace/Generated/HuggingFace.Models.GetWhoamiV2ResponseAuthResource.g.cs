
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWhoamiV2ResponseAuthResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sub { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhoamiV2ResponseAuthResource" /> class.
        /// </summary>
        /// <param name="sub"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWhoamiV2ResponseAuthResource(
            string sub)
        {
            this.Sub = sub ?? throw new global::System.ArgumentNullException(nameof(sub));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhoamiV2ResponseAuthResource" /> class.
        /// </summary>
        public GetWhoamiV2ResponseAuthResource()
        {
        }
    }
}