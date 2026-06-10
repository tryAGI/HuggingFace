
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsBillingUsageByInferenceSessionResponsePeriod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Period { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriodSession> Sessions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByInferenceSessionResponsePeriod" /> class.
        /// </summary>
        /// <param name="period"></param>
        /// <param name="sessions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationsBillingUsageByInferenceSessionResponsePeriod(
            global::System.DateTime period,
            global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriodSession> sessions)
        {
            this.Period = period;
            this.Sessions = sessions ?? throw new global::System.ArgumentNullException(nameof(sessions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingUsageByInferenceSessionResponsePeriod" /> class.
        /// </summary>
        public GetOrganizationsBillingUsageByInferenceSessionResponsePeriod()
        {
        }

    }
}