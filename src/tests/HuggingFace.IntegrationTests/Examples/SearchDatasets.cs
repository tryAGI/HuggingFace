/*
order: 150
title: Search Datasets
slug: search-datasets

Search for datasets on the HuggingFace Hub using quicksearch and list results.
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SearchDatasets()
    {
        var apiKey = GetApiKey();
        using var client = new HuggingFaceClient(apiKey);

        var response = await client.RepoSearch.CreateQuicksearchAsync(
            request: new Request57
            {
                Q = "sentiment analysis",
                Limit = 5,
                Exclude = [],
            });

        Console.WriteLine($"Models: {response.ModelsCount}, Datasets: {response.DatasetsCount}, Spaces: {response.SpacesCount}");

        foreach (var dataset in response.Datasets)
        {
            Console.WriteLine($"  Dataset: {dataset.Id}");
        }

        foreach (var space in response.Spaces)
        {
            Console.WriteLine($"  Space: {space.Id}");
        }

        (response.ModelsCount + response.DatasetsCount + response.SpacesCount).Should().BeGreaterThan(0);
    }
}
