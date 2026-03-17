
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionRequest
    {
        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far,<br/>
        /// decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Example: 1.0
        /// </summary>
        /// <example>1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// The maximum number of tokens that can be generated in the chat completion.<br/>
        /// Default Value: 1024<br/>
        /// Example: 32
        /// </summary>
        /// <example>32</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// UNUSED<br/>
        /// ID of the model to use. See the model endpoint compatibility table for details on which models work with the Chat API.<br/>
        /// Example: mistralai/Mistral-7B-Instruct-v0.2
        /// </summary>
        /// <example>mistralai/Mistral-7B-Instruct-v0.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_penalty")]
        public float? RepetitionPenalty { get; set; }

        /// <summary>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens.<br/>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// The text to append to the prompt. This is useful for completing sentences or generating a paragraph of text.<br/>
        /// please see the completion_template field in the model's tokenizer_config.json file for completion template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while<br/>
        /// lower values like 0.2 will make it more focused and deterministic. We generally recommend altering this or `top_p` but not both.<br/>
        /// Example: 1F
        /// </summary>
        /// <example>1F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the<br/>
        /// tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// Example: 0.95F
        /// </summary>
        /// <example>0.95F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionRequest" /> class.
        /// </summary>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far,<br/>
        /// decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Example: 1.0
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens that can be generated in the chat completion.<br/>
        /// Default Value: 1024<br/>
        /// Example: 32
        /// </param>
        /// <param name="model">
        /// UNUSED<br/>
        /// ID of the model to use. See the model endpoint compatibility table for details on which models work with the Chat API.<br/>
        /// Example: mistralai/Mistral-7B-Instruct-v0.2
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="repetitionPenalty"></param>
        /// <param name="seed">
        /// Example: 42
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.<br/>
        /// Example: null
        /// </param>
        /// <param name="stream"></param>
        /// <param name="suffix">
        /// The text to append to the prompt. This is useful for completing sentences or generating a paragraph of text.<br/>
        /// please see the completion_template field in the model's tokenizer_config.json file for completion template.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while<br/>
        /// lower values like 0.2 will make it more focused and deterministic. We generally recommend altering this or `top_p` but not both.<br/>
        /// Example: 1F
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the<br/>
        /// tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// Example: 0.95F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionRequest(
            global::System.Collections.Generic.IList<string> prompt,
            float? frequencyPenalty,
            int? maxTokens,
            string? model,
            float? repetitionPenalty,
            long? seed,
            global::System.Collections.Generic.IList<string>? stop,
            bool? stream,
            string? suffix,
            float? temperature,
            float? topP)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.FrequencyPenalty = frequencyPenalty;
            this.MaxTokens = maxTokens;
            this.Model = model;
            this.RepetitionPenalty = repetitionPenalty;
            this.Seed = seed;
            this.Stop = stop;
            this.Stream = stream;
            this.Suffix = suffix;
            this.Temperature = temperature;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionRequest" /> class.
        /// </summary>
        public CompletionRequest()
        {
        }
    }
}