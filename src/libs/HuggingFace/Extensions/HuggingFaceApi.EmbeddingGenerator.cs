using Microsoft.Extensions.AI;

// ReSharper disable once CheckNamespace

namespace HuggingFace;

public partial class HuggingFaceEmbeddingClient : IEmbeddingGenerator<string, Embedding<float>>
{
    private EmbeddingGeneratorMetadata? _embeddingMetadata;

    /// <inheritdoc />
    object? IEmbeddingGenerator.GetService(Type serviceType, object? serviceKey)
    {
        return
            serviceKey is not null ? null :
            serviceType == typeof(EmbeddingGeneratorMetadata) ? (_embeddingMetadata ??= new(nameof(HuggingFaceEmbeddingClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    /// <inheritdoc />
    async Task<GeneratedEmbeddings<Embedding<float>>> IEmbeddingGenerator<string, Embedding<float>>.GenerateAsync(
        IEnumerable<string> values,
        EmbeddingGenerationOptions? options,
        CancellationToken cancellationToken)
    {
        var inputList = values.ToList();
        var inputTypes = inputList.Select(s => new InputType(s)).ToList();

        var request = new OpenAICompatRequest
        {
            Input = new Input(value1: null, value2: inputTypes),
            Model = options?.ModelId,
            Dimensions = options?.Dimensions,
        };

        var response = await OpenaiEmbedAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false);

        var embeddings = new GeneratedEmbeddings<Embedding<float>>();

        foreach (var item in response.Data.OrderBy(d => d.Index))
        {
            var vector = item.Embedding.Value1;
            if (vector is not null)
            {
                embeddings.Add(new Embedding<float>(vector.ToArray())
                {
                    ModelId = response.Model,
                });
            }
        }

        embeddings.Usage = new()
        {
            InputTokenCount = response.Usage.PromptTokens,
            TotalTokenCount = response.Usage.TotalTokens,
        };

        return embeddings;
    }
}
