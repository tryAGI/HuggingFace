
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::HuggingFace.JsonConverters.CompletionVariant1ObjectJsonConverter),

            typeof(global::HuggingFace.JsonConverters.CompletionVariant1ObjectNullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.CompletionVariant2ObjectJsonConverter),

            typeof(global::HuggingFace.JsonConverters.CompletionVariant2ObjectNullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.FinishReasonJsonConverter),

            typeof(global::HuggingFace.JsonConverters.FinishReasonNullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant1TypeJsonConverter),

            typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant1TypeNullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant2TypeJsonConverter),

            typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant2TypeNullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant3TypeJsonConverter),

            typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant3TypeNullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.GrammarTypeDiscriminatorTypeJsonConverter),

            typeof(global::HuggingFace.JsonConverters.GrammarTypeDiscriminatorTypeNullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.MessageChunkVariant1TypeJsonConverter),

            typeof(global::HuggingFace.JsonConverters.MessageChunkVariant1TypeNullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.MessageChunkVariant2TypeJsonConverter),

            typeof(global::HuggingFace.JsonConverters.MessageChunkVariant2TypeNullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.MessageChunkDiscriminatorTypeJsonConverter),

            typeof(global::HuggingFace.JsonConverters.MessageChunkDiscriminatorTypeNullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.ToolChoiceVariant1JsonConverter),

            typeof(global::HuggingFace.JsonConverters.ToolChoiceVariant1NullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.ToolChoiceVariant2JsonConverter),

            typeof(global::HuggingFace.JsonConverters.ToolChoiceVariant2NullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.ToolChoiceVariant3JsonConverter),

            typeof(global::HuggingFace.JsonConverters.ToolChoiceVariant3NullableJsonConverter),

            typeof(global::HuggingFace.JsonConverters.ChatCompletionDeltaJsonConverter),

            typeof(global::HuggingFace.JsonConverters.CompletionJsonConverter),

            typeof(global::HuggingFace.JsonConverters.GrammarTypeJsonConverter),

            typeof(global::HuggingFace.JsonConverters.MessageJsonConverter),

            typeof(global::HuggingFace.JsonConverters.MessageBodyJsonConverter),

            typeof(global::HuggingFace.JsonConverters.MessageChunkJsonConverter),

            typeof(global::HuggingFace.JsonConverters.MessageContentJsonConverter),

            typeof(global::HuggingFace.JsonConverters.OutputMessageJsonConverter),

            typeof(global::HuggingFace.JsonConverters.SagemakerRequestJsonConverter),

            typeof(global::HuggingFace.JsonConverters.SagemakerResponseJsonConverter),

            typeof(global::HuggingFace.JsonConverters.SagemakerStreamResponseJsonConverter),

            typeof(global::HuggingFace.JsonConverters.ToolChoiceJsonConverter),

            typeof(global::HuggingFace.JsonConverters.AllOfJsonConverter<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>),

            typeof(global::HuggingFace.JsonConverters.AllOfJsonConverter<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>),

            typeof(global::HuggingFace.JsonConverters.UnixTimestampJsonConverter),
        })]
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.HuggingFaceInferenceSourceGenerationContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.BestOfSequence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.FinishReason), TypeInfoPropertyName = "FinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PrefillToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PrefillToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.Token>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Token))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.Token>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ChatCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.ChatCompletionComplete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ChatCompletionComplete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ChatCompletionDelta), TypeInfoPropertyName = "ChatCompletionDelta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ChatCompletionLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ChatCompletionChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OutputMessage), TypeInfoPropertyName = "OutputMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.TextMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ToolCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ChatCompletionLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.ChatCompletionTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ChatCompletionTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.ChatCompletionLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Message), TypeInfoPropertyName = "Message2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GrammarType), TypeInfoPropertyName = "GrammarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.StreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ToolChoice), TypeInfoPropertyName = "ToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ChatTokenizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.SimpleToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Chunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CompletionComplete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CompletionComplete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CompatGenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GenerateParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Completion), TypeInfoPropertyName = "Completion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AllOf<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>), TypeInfoPropertyName = "AllOfChunkCompletionVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CompletionVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CompletionVariant1Object), TypeInfoPropertyName = "CompletionVariant1Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AllOf<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>), TypeInfoPropertyName = "AllOfCompletionFinalCompletionVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CompletionFinal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CompletionVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CompletionVariant2Object), TypeInfoPropertyName = "CompletionVariant2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CompletionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.DeltaToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.BestOfSequence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.FunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.FunctionName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GenerateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GrammarTypeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GrammarTypeVariant1Type), TypeInfoPropertyName = "GrammarTypeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GrammarTypeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GrammarTypeVariant2Type), TypeInfoPropertyName = "GrammarTypeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GrammarTypeVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GrammarTypeVariant3Type), TypeInfoPropertyName = "GrammarTypeVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.JsonSchemaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GrammarTypeDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GrammarTypeDiscriminatorType), TypeInfoPropertyName = "GrammarTypeDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Info))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.MessageBody), TypeInfoPropertyName = "MessageBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.MessageVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.MessageBodyVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.MessageContent), TypeInfoPropertyName = "MessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.MessageBodyVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.MessageChunk), TypeInfoPropertyName = "MessageChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.MessageChunkVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.MessageChunkVariant1Type), TypeInfoPropertyName = "MessageChunkVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.MessageChunkVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Url))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.MessageChunkVariant2Type), TypeInfoPropertyName = "MessageChunkVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.MessageChunkDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.MessageChunkDiscriminatorType), TypeInfoPropertyName = "MessageChunkDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.MessageChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ToolCallMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.SagemakerRequest), TypeInfoPropertyName = "SagemakerRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.SagemakerResponse), TypeInfoPropertyName = "SagemakerResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.SagemakerStreamResponse), TypeInfoPropertyName = "SagemakerStreamResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.StreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.SimpleToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.StreamDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.DeltaToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ToolChoiceVariant1), TypeInfoPropertyName = "ToolChoiceVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ToolChoiceVariant2), TypeInfoPropertyName = "ToolChoiceVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ToolChoiceVariant3), TypeInfoPropertyName = "ToolChoiceVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ToolChoiceVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GenerateResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PrefillToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.Token>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::HuggingFace.Token>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.ChatCompletionComplete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.ChatCompletionTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.ChatCompletionLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.SimpleToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CompletionComplete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.BestOfSequence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.MessageChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.DeltaToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GenerateResponse>))]
    public sealed partial class HuggingFaceInferenceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}