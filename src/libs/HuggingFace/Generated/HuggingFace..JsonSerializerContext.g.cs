
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
            typeof(global::HuggingFace.JsonConverters.TruncationDirectionJsonConverter),
            typeof(global::HuggingFace.JsonConverters.TruncationDirectionNullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.EncodingFormatJsonConverter),
            typeof(global::HuggingFace.JsonConverters.EncodingFormatNullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.ErrorTypeJsonConverter),
            typeof(global::HuggingFace.JsonConverters.ErrorTypeNullableJsonConverter),
            typeof(global::HuggingFace.JsonConverters.InputIdsJsonConverter),
            typeof(global::HuggingFace.JsonConverters.InputJsonConverter),
            typeof(global::HuggingFace.JsonConverters.InputTypeJsonConverter),
            typeof(global::HuggingFace.JsonConverters.EmbeddingJsonConverter),
            typeof(global::HuggingFace.JsonConverters.ModelTypeJsonConverter),
            typeof(global::HuggingFace.JsonConverters.PredictInputJsonConverter),
            typeof(global::HuggingFace.JsonConverters.PredictResponseJsonConverter),
            typeof(global::HuggingFace.JsonConverters.TokenizeInputJsonConverter),
            typeof(global::HuggingFace.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}