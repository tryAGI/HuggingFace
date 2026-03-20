/*
order: 170
title: Search Papers
slug: search-papers

Search for papers and collections on the HuggingFace Hub.
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SearchPapers()
    {
        var apiKey = GetApiKey();
        using var client = new HuggingFaceClient(apiKey);

        var response = await client.RepoSearch.CreateQuicksearchAsync(
            request: new Request57
            {
                Q = "transformer attention",
                Limit = 5,
                Exclude = [],
            });

        Console.WriteLine($"Papers: {response.PapersCount}, Collections: {response.CollectionsCount}");

        foreach (var paper in response.Papers)
        {
            Console.WriteLine($"  Paper: {paper.Id}");
        }

        foreach (var collection in response.Collections)
        {
            Console.WriteLine($"  Collection: {collection.Title} - {collection.Description}");
        }

        response.Papers.Should().NotBeEmpty();
    }
}
