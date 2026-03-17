
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::HuggingFace.RequestUser>? Users { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        public global::System.Collections.Generic.IList<global::HuggingFace.RepoId>? Repos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoJoin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.RequestAutoJoinVariant1, global::HuggingFace.RequestAutoJoinVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.RequestAutoJoinVariant1, global::HuggingFace.RequestAutoJoinVariant2>? AutoJoin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request8" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="users">
        /// Default Value: []
        /// </param>
        /// <param name="repos">
        /// Default Value: []
        /// </param>
        /// <param name="autoJoin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request8(
            string name,
            string? description,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestUser>? users,
            global::System.Collections.Generic.IList<global::HuggingFace.RepoId>? repos,
            global::HuggingFace.AnyOf<global::HuggingFace.RequestAutoJoinVariant1, global::HuggingFace.RequestAutoJoinVariant2>? autoJoin)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Users = users;
            this.Repos = repos;
            this.AutoJoin = autoJoin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request8" /> class.
        /// </summary>
        public Request8()
        {
        }
    }
}