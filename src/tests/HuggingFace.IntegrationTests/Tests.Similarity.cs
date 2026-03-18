namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    //// ## Similarity
    ////
    //// The TEI similarity endpoint computes cosine similarity scores between
    //// a source sentence and a list of candidate sentences.

    //// ### Compare sentences against a source
    [TestMethod]
    public async Task Similarity_BasicAsync()
    {
        using var client = GetAuthenticatedEmbeddingClient();

        var scores = await client.SimilarityAsync(
            inputs: new SimilarityInput
            {
                SourceSentence = "What is Deep Learning?",
                Sentences =
                [
                    "Deep Learning is a subset of Machine Learning.",
                    "The weather is sunny today.",
                    "Neural networks are inspired by the human brain.",
                ],
            });

        scores.Should().NotBeNull();
        scores.Should().HaveCount(3);

        for (var i = 0; i < scores.Count; i++)
        {
            Console.WriteLine($"[{i}] similarity={scores[i]:F4}");
        }

        // "Deep Learning is a subset of ML" should be more similar to the query than "weather is sunny"
        scores[0].Should().BeGreaterThan(scores[1]);
    }
}
