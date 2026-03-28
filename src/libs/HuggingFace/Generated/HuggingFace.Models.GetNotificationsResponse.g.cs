
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetNotificationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetNotificationsResponseNotificationVariant1, global::HuggingFace.GetNotificationsResponseNotificationVariant2, global::HuggingFace.GetNotificationsResponseNotificationVariant3, global::HuggingFace.GetNotificationsResponseNotificationVariant4>> Notifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetNotificationsResponseCount Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotificationsResponse" /> class.
        /// </summary>
        /// <param name="notifications"></param>
        /// <param name="count"></param>
        /// <param name="start"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetNotificationsResponse(
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetNotificationsResponseNotificationVariant1, global::HuggingFace.GetNotificationsResponseNotificationVariant2, global::HuggingFace.GetNotificationsResponseNotificationVariant3, global::HuggingFace.GetNotificationsResponseNotificationVariant4>> notifications,
            global::HuggingFace.GetNotificationsResponseCount count,
            double start)
        {
            this.Notifications = notifications ?? throw new global::System.ArgumentNullException(nameof(notifications));
            this.Count = count ?? throw new global::System.ArgumentNullException(nameof(count));
            this.Start = start;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotificationsResponse" /> class.
        /// </summary>
        public GetNotificationsResponse()
        {
        }
    }
}