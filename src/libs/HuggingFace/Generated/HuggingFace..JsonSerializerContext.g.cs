
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::HuggingFace.JsonConverters.FinishReasonJsonConverter),
            typeof(global::HuggingFace.JsonConverters.FinishReasonNullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.MessageChunkVariant1TypeJsonConverter),
            typeof(global::HuggingFace.JsonConverters.MessageChunkVariant1TypeNullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.MessageChunkVariant2TypeJsonConverter),
            typeof(global::HuggingFace.JsonConverters.MessageChunkVariant2TypeNullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant1TypeJsonConverter),
            typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant1TypeNullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant2TypeJsonConverter),
            typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant2TypeNullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant3TypeJsonConverter),
            typeof(global::HuggingFace.JsonConverters.GrammarTypeVariant3TypeNullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.ToolChoiceVariant1JsonConverter),
            typeof(global::HuggingFace.JsonConverters.ToolChoiceVariant1NullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.ToolChoiceVariant2JsonConverter),
            typeof(global::HuggingFace.JsonConverters.ToolChoiceVariant2NullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.ToolChoiceVariant3JsonConverter),
            typeof(global::HuggingFace.JsonConverters.ToolChoiceVariant3NullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.CompletionVariant1ObjectJsonConverter),
            typeof(global::HuggingFace.JsonConverters.CompletionVariant1ObjectNullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.CompletionVariant2ObjectJsonConverter),
            typeof(global::HuggingFace.JsonConverters.CompletionVariant2ObjectNullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.OutputMessageJsonConverter),
            typeof(global::HuggingFace.JsonConverters.ChatCompletionDeltaJsonConverter),
            typeof(global::HuggingFace.JsonConverters.MessageJsonConverter),
            typeof(global::HuggingFace.JsonConverters.MessageBodyJsonConverter),
            typeof(global::HuggingFace.JsonConverters.MessageContentJsonConverter),
            typeof(global::HuggingFace.JsonConverters.MessageChunkJsonConverter),
            typeof(global::HuggingFace.JsonConverters.GrammarTypeJsonConverter),
            typeof(global::HuggingFace.JsonConverters.ToolChoiceJsonConverter),
            typeof(global::HuggingFace.JsonConverters.CompletionJsonConverter),
            typeof(global::HuggingFace.JsonConverters.SagemakerRequestJsonConverter),
            typeof(global::HuggingFace.JsonConverters.SagemakerResponseJsonConverter),
            typeof(global::HuggingFace.JsonConverters.SagemakerStreamResponseJsonConverter),
            typeof(global::HuggingFace.JsonConverters.AllOfJsonConverter<global::HuggingFace.Chunk, global::HuggingFace.CompletionVariant12>),
            typeof(global::HuggingFace.JsonConverters.AllOfJsonConverter<global::HuggingFace.CompletionFinal, global::HuggingFace.CompletionVariant22>),
            typeof(global::HuggingFace.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}