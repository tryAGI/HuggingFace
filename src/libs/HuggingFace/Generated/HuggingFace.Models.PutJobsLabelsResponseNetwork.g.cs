
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Network group the job belongs to.
    /// </summary>
    public sealed partial class PutJobsLabelsResponseNetwork
    {
        /// <summary>
        /// Group name, scoped to the job's owner and resource group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Group { get; set; }

        /// <summary>
        /// Roles this job answers to. An alias names a role, not a job: several members may claim the same alias, which then resolves to all of them, and a member may claim several. Peers get the hostname by appending the alias to the `HF_NETWORK_GROUP_PREFIX` environment variable, which already ends with a separator.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutJobsLabelsResponseNetwork" /> class.
        /// </summary>
        /// <param name="group">
        /// Group name, scoped to the job's owner and resource group.
        /// </param>
        /// <param name="aliases">
        /// Roles this job answers to. An alias names a role, not a job: several members may claim the same alias, which then resolves to all of them, and a member may claim several. Peers get the hostname by appending the alias to the `HF_NETWORK_GROUP_PREFIX` environment variable, which already ends with a separator.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutJobsLabelsResponseNetwork(
            string group,
            global::System.Collections.Generic.IList<string> aliases)
        {
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
            this.Aliases = aliases ?? throw new global::System.ArgumentNullException(nameof(aliases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutJobsLabelsResponseNetwork" /> class.
        /// </summary>
        public PutJobsLabelsResponseNetwork()
        {
        }

    }
}