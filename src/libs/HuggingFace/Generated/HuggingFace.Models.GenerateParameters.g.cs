
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateParameters
    {
        /// <summary>
        /// Lora adapter id<br/>
        /// Default Value: null<br/>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_id")]
        public string? AdapterId { get; set; }

        /// <summary>
        /// Generate best_of sequences and return the one if the highest token logprobs.<br/>
        /// Default Value: null<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("best_of")]
        public int? BestOf { get; set; }

        /// <summary>
        /// Whether to return decoder input token logprobs and ids.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decoder_input_details")]
        public bool? DecoderInputDetails { get; set; }

        /// <summary>
        /// Whether to return generation details.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public bool? Details { get; set; }

        /// <summary>
        /// Activate logits sampling.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_sample")]
        public bool? DoSample { get; set; }

        /// <summary>
        /// The parameter for frequency penalty. 1.0 means no penalty<br/>
        /// Penalize new tokens based on their existing frequency in the text so far,<br/>
        /// decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Default Value: null<br/>
        /// Example: 0.1F
        /// </summary>
        /// <example>0.1F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// Default Value: null
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grammar")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GrammarTypeJsonConverter))]
        public global::HuggingFace.GrammarType? Grammar { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 1024<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_new_tokens")]
        public int? MaxNewTokens { get; set; }

        /// <summary>
        /// The parameter for repetition penalty. 1.0 means no penalty.<br/>
        /// See [this paper](https://arxiv.org/pdf/1909.05858.pdf) for more details.<br/>
        /// Default Value: null<br/>
        /// Example: 1.03F
        /// </summary>
        /// <example>1.03F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_penalty")]
        public float? RepetitionPenalty { get; set; }

        /// <summary>
        /// Whether to prepend the prompt to the generated text<br/>
        /// Default Value: null<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_full_text")]
        public bool? ReturnFullText { get; set; }

        /// <summary>
        /// Random sampling seed.<br/>
        /// Default Value: null<br/>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Stop generating tokens if a member of `stop` is generated.<br/>
        /// Example: [photographer]
        /// </summary>
        /// <example>[photographer]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// The value used to module the logits distribution.<br/>
        /// Default Value: null<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// The number of highest probability vocabulary tokens to keep for top-k-filtering.<br/>
        /// Default Value: null<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// The number of highest probability vocabulary tokens to keep for top-n-filtering.<br/>
        /// Default Value: null<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n_tokens")]
        public int? TopNTokens { get; set; }

        /// <summary>
        /// Top-p value for nucleus sampling.<br/>
        /// Default Value: null<br/>
        /// Example: 0.95F
        /// </summary>
        /// <example>0.95F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// Truncate inputs tokens to the given size.<br/>
        /// Default Value: null<br/>
        /// Example: null
        /// </summary>
        /// <example>null</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        public int? Truncate { get; set; }

        /// <summary>
        /// Typical Decoding mass<br/>
        /// See [Typical Decoding for Natural Language Generation](https://arxiv.org/abs/2202.00666) for more information.<br/>
        /// Default Value: null<br/>
        /// Example: 0.95F
        /// </summary>
        /// <example>0.95F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("typical_p")]
        public float? TypicalP { get; set; }

        /// <summary>
        /// Watermarking with [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark")]
        public bool? Watermark { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateParameters" /> class.
        /// </summary>
        /// <param name="adapterId">
        /// Lora adapter id<br/>
        /// Default Value: null<br/>
        /// Example: null
        /// </param>
        /// <param name="bestOf">
        /// Generate best_of sequences and return the one if the highest token logprobs.<br/>
        /// Default Value: null<br/>
        /// Example: 1
        /// </param>
        /// <param name="decoderInputDetails">
        /// Whether to return decoder input token logprobs and ids.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="details">
        /// Whether to return generation details.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="doSample">
        /// Activate logits sampling.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="frequencyPenalty">
        /// The parameter for frequency penalty. 1.0 means no penalty<br/>
        /// Penalize new tokens based on their existing frequency in the text so far,<br/>
        /// decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Default Value: null<br/>
        /// Example: 0.1F
        /// </param>
        /// <param name="grammar">
        /// Default Value: null
        /// </param>
        /// <param name="maxNewTokens">
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 1024<br/>
        /// Example: 20
        /// </param>
        /// <param name="repetitionPenalty">
        /// The parameter for repetition penalty. 1.0 means no penalty.<br/>
        /// See [this paper](https://arxiv.org/pdf/1909.05858.pdf) for more details.<br/>
        /// Default Value: null<br/>
        /// Example: 1.03F
        /// </param>
        /// <param name="returnFullText">
        /// Whether to prepend the prompt to the generated text<br/>
        /// Default Value: null<br/>
        /// Example: false
        /// </param>
        /// <param name="seed">
        /// Random sampling seed.<br/>
        /// Default Value: null<br/>
        /// Example: null
        /// </param>
        /// <param name="stop">
        /// Stop generating tokens if a member of `stop` is generated.<br/>
        /// Example: [photographer]
        /// </param>
        /// <param name="temperature">
        /// The value used to module the logits distribution.<br/>
        /// Default Value: null<br/>
        /// Example: 0.5F
        /// </param>
        /// <param name="topK">
        /// The number of highest probability vocabulary tokens to keep for top-k-filtering.<br/>
        /// Default Value: null<br/>
        /// Example: 10
        /// </param>
        /// <param name="topNTokens">
        /// The number of highest probability vocabulary tokens to keep for top-n-filtering.<br/>
        /// Default Value: null<br/>
        /// Example: 5
        /// </param>
        /// <param name="topP">
        /// Top-p value for nucleus sampling.<br/>
        /// Default Value: null<br/>
        /// Example: 0.95F
        /// </param>
        /// <param name="truncate">
        /// Truncate inputs tokens to the given size.<br/>
        /// Default Value: null<br/>
        /// Example: null
        /// </param>
        /// <param name="typicalP">
        /// Typical Decoding mass<br/>
        /// See [Typical Decoding for Natural Language Generation](https://arxiv.org/abs/2202.00666) for more information.<br/>
        /// Default Value: null<br/>
        /// Example: 0.95F
        /// </param>
        /// <param name="watermark">
        /// Watermarking with [A Watermark for Large Language Models](https://arxiv.org/abs/2301.10226).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateParameters(
            string? adapterId,
            int? bestOf,
            bool? decoderInputDetails,
            bool? details,
            bool? doSample,
            float? frequencyPenalty,
            global::HuggingFace.GrammarType? grammar,
            int? maxNewTokens,
            float? repetitionPenalty,
            bool? returnFullText,
            long? seed,
            global::System.Collections.Generic.IList<string>? stop,
            float? temperature,
            int? topK,
            int? topNTokens,
            float? topP,
            int? truncate,
            float? typicalP,
            bool? watermark)
        {
            this.AdapterId = adapterId;
            this.BestOf = bestOf;
            this.DecoderInputDetails = decoderInputDetails;
            this.Details = details;
            this.DoSample = doSample;
            this.FrequencyPenalty = frequencyPenalty;
            this.Grammar = grammar;
            this.MaxNewTokens = maxNewTokens;
            this.RepetitionPenalty = repetitionPenalty;
            this.ReturnFullText = returnFullText;
            this.Seed = seed;
            this.Stop = stop;
            this.Temperature = temperature;
            this.TopK = topK;
            this.TopNTokens = topNTokens;
            this.TopP = topP;
            this.Truncate = truncate;
            this.TypicalP = typicalP;
            this.Watermark = watermark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateParameters" /> class.
        /// </summary>
        public GenerateParameters()
        {
        }
    }
}