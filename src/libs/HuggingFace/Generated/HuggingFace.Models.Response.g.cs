
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.ResponseNotificationVariant1, global::HuggingFace.ResponseNotificationVariant2, global::HuggingFace.ResponseNotificationVariant3, global::HuggingFace.ResponseNotificationVariant4>> Notifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseCount Count { get; set; }

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
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        /// <param name="notifications"></param>
        /// <param name="count"></param>
        /// <param name="start"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response(
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.ResponseNotificationVariant1, global::HuggingFace.ResponseNotificationVariant2, global::HuggingFace.ResponseNotificationVariant3, global::HuggingFace.ResponseNotificationVariant4>> notifications,
            global::HuggingFace.ResponseCount count,
            double start)
        {
            this.Notifications = notifications ?? throw new global::System.ArgumentNullException(nameof(notifications));
            this.Count = count ?? throw new global::System.ArgumentNullException(nameof(count));
            this.Start = start;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        public Response()
        {
        }
    }
}