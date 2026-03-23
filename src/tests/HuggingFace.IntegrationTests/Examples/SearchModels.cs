/*
order: 130
title: Search Models
slug: search-models

Search for models, datasets, and spaces on the HuggingFace Hub using quicksearch.
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SearchModels()
    {
        var apiKey = GetApiKey();
        using var client = new HuggingFaceClient(apiKey);

        var response = await client.RepoSearch.CreateQuicksearchAsync(
            request: new CreateQuicksearchRequest
            {
                Q = "text-generation",
                Limit = 5,
                Exclude = [],
            });

        Console.WriteLine($"Found {response.ModelsCount} models, {response.DatasetsCount} datasets");

        foreach (var model in response.Models)
        {
            Console.WriteLine($"  {model.Id} (weight={model.TrendingWeight:F2})");
        }

        response.Models.Should().NotBeEmpty();
    }
}
