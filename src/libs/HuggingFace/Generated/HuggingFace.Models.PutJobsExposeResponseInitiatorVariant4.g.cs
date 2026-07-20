
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutJobsExposeResponseInitiatorVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"webhook"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "webhook";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutJobsExposeResponseInitiatorVariant4" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutJobsExposeResponseInitiatorVariant4(
            string id,
            string type = "webhook")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutJobsExposeResponseInitiatorVariant4" /> class.
        /// </summary>
        public PutJobsExposeResponseInitiatorVariant4()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PutJobsExposeResponseInitiatorVariant4"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PutJobsExposeResponseInitiatorVariant4 FromId(string id)
        {
            return new PutJobsExposeResponseInitiatorVariant4
            {
                Id = id,
            };
        }

    }
}