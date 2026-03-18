
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ClassifierModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.DecodeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.InputIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.EmbedAllRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Input))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.InputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.InputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.TruncationDirection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.EmbedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.EmbedSparseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.SparseValue>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.SparseValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.SparseValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Embedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.EmbeddingModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.EncodingFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ErrorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Info))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ModelType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ModelTypeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ModelTypeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.ModelTypeVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OpenAICompatEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OpenAICompatErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OpenAICompatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OpenAICompatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.OpenAICompatEmbedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OpenAICompatUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PredictInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PredictRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PredictResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.Prediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Prediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.Prediction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.Rank))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.RerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.Rank>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.SimilarityInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.SimilarityParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.SimilarityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.SimpleToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.TokenizeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.TokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.SimpleToken>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.SimpleToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.InputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::HuggingFace.SparseValue>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.SparseValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.OpenAICompatEmbedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.Prediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::HuggingFace.Prediction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.Rank>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::HuggingFace.SimpleToken>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.SimpleToken>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}