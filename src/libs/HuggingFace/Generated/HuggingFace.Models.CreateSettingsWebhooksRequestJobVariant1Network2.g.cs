
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Opt-in network group. Jobs of the same owner and resource group sharing a group are placed together and reach each other on every port. Two environment variables are set in the container: `HF_NETWORK_GROUP_HOSTNAME`, a hostname resolving to every member of the group, and `HF_NETWORK_GROUP_PREFIX`, to which an alias is appended to get that alias' hostname.
    /// </summary>
    public sealed partial class CreateSettingsWebhooksRequestJobVariant1Network2
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
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequestJobVariant1Network2" /> class.
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
        public CreateSettingsWebhooksRequestJobVariant1Network2(
            string group,
            global::System.Collections.Generic.IList<string>? aliases)
        {
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
            this.Aliases = aliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequestJobVariant1Network2" /> class.
        /// </summary>
        public CreateSettingsWebhooksRequestJobVariant1Network2()
        {
        }

    }
}