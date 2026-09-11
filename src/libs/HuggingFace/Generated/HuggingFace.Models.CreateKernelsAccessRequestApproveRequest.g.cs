
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateKernelsAccessRequestApproveRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sendEmail")]
        public bool? SendEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKernelsAccessRequestApproveRequest" /> class.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="sendEmail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKernelsAccessRequestApproveRequest(
            string @namespace,
            bool? sendEmail)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.SendEmail = sendEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKernelsAccessRequestApproveRequest" /> class.
        /// </summary>
        public CreateKernelsAccessRequestApproveRequest()
        {
        }

    }
}