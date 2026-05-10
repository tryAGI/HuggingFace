
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCollectionsItemsResponseGatingVariant32
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"manual"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string Mode { get; set; } = "manual";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateCollectionsItemsResponseGatingVariant3Notifications2 Notifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsItemsResponseGatingVariant32" /> class.
        /// </summary>
        /// <param name="notifications"></param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsItemsResponseGatingVariant32(
            global::HuggingFace.CreateCollectionsItemsResponseGatingVariant3Notifications2 notifications,
            string mode = "manual")
        {
            this.Mode = mode;
            this.Notifications = notifications ?? throw new global::System.ArgumentNullException(nameof(notifications));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsItemsResponseGatingVariant32" /> class.
        /// </summary>
        public CreateCollectionsItemsResponseGatingVariant32()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateCollectionsItemsResponseGatingVariant32"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateCollectionsItemsResponseGatingVariant32 FromNotifications(global::HuggingFace.CreateCollectionsItemsResponseGatingVariant3Notifications2 notifications)
        {
            return new CreateCollectionsItemsResponseGatingVariant32
            {
                Notifications = notifications,
            };
        }

    }
}