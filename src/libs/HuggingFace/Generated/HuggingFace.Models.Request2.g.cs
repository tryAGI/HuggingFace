
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.RequestNotifications Notifications { get; set; }

        /// <summary>
        /// To be provided when enabling launch_prepaid_credits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prepaidAmount")]
        public string? PrepaidAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request2" /> class.
        /// </summary>
        /// <param name="notifications"></param>
        /// <param name="prepaidAmount">
        /// To be provided when enabling launch_prepaid_credits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request2(
            global::HuggingFace.RequestNotifications notifications,
            string? prepaidAmount)
        {
            this.Notifications = notifications ?? throw new global::System.ArgumentNullException(nameof(notifications));
            this.PrepaidAmount = prepaidAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request2" /> class.
        /// </summary>
        public Request2()
        {
        }
    }
}