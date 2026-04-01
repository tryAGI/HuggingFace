
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutSpacesVolumesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.PutSpacesVolumesRequestVolume> Volumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSpacesVolumesRequest" /> class.
        /// </summary>
        /// <param name="volumes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutSpacesVolumesRequest(
            global::System.Collections.Generic.IList<global::HuggingFace.PutSpacesVolumesRequestVolume> volumes)
        {
            this.Volumes = volumes ?? throw new global::System.ArgumentNullException(nameof(volumes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSpacesVolumesRequest" /> class.
        /// </summary>
        public PutSpacesVolumesRequest()
        {
        }
    }
}