
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Schemas { get; set; }

        /// <summary>
        /// Username for the user, it should respect the hub rules: No consecutive dashes, No digit-only, Does not start or end with a dash, Only dashes, letters or numbers, Not 24 chars hex string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.RequestEmail> Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.RequestName Name { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// External ID for the user, it must be unique within the organization and is required for managed users
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request10" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="userName">
        /// Username for the user, it should respect the hub rules: No consecutive dashes, No digit-only, Does not start or end with a dash, Only dashes, letters or numbers, Not 24 chars hex string
        /// </param>
        /// <param name="emails"></param>
        /// <param name="name"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="externalId">
        /// External ID for the user, it must be unique within the organization and is required for managed users
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request10(
            global::System.Collections.Generic.IList<string> schemas,
            string userName,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestEmail> emails,
            global::HuggingFace.RequestName name,
            string externalId,
            bool? active)
        {
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request10" /> class.
        /// </summary>
        public Request10()
        {
        }
    }
}