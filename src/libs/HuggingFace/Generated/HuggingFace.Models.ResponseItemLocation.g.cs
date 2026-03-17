
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItemLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Formatted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemLocation" /> class.
        /// </summary>
        /// <param name="formatted"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItemLocation(
            string formatted,
            string? country,
            string? city)
        {
            this.Formatted = formatted ?? throw new global::System.ArgumentNullException(nameof(formatted));
            this.Country = country;
            this.City = city;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemLocation" /> class.
        /// </summary>
        public ResponseItemLocation()
        {
        }
    }
}