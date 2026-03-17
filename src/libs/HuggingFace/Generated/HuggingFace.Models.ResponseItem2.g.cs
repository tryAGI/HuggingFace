
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItem2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public global::HuggingFace.ResponseItemLocation? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseItemAuthor Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public global::HuggingFace.ResponseItemToken? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth")]
        public global::HuggingFace.ResponseItemOauth? Oauth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <param name="message"></param>
        /// <param name="ip"></param>
        /// <param name="location"></param>
        /// <param name="userAgent"></param>
        /// <param name="author"></param>
        /// <param name="token"></param>
        /// <param name="oauth"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItem2(
            string id,
            global::System.DateTime createdAt,
            global::HuggingFace.ResponseItemType type,
            string message,
            global::HuggingFace.ResponseItemAuthor author,
            object? data,
            string? ip,
            global::HuggingFace.ResponseItemLocation? location,
            string? userAgent,
            global::HuggingFace.ResponseItemToken? token,
            global::HuggingFace.ResponseItemOauth? oauth)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Data = data;
            this.Ip = ip;
            this.Location = location;
            this.UserAgent = userAgent;
            this.Token = token;
            this.Oauth = oauth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem2" /> class.
        /// </summary>
        public ResponseItem2()
        {
        }
    }
}