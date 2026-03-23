/*
order: 160
title: Trending by Type
slug: trending-by-type

List trending items filtered by type (model, dataset, or space).
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TrendingByType()
    {
        var apiKey = GetApiKey();
        using var client = new HuggingFaceClient(apiKey);

        var spaces = await client.Models.GetTrendingAsync(
            type: GetTrendingType.Space,
            limit: 3);

        Console.WriteLine("Trending Spaces:");
        foreach (var item in spaces.RecentlyTrending)
        {
            var id = item.Value1?.RepoData?.Id ?? item.Value2?.RepoData?.Id ?? item.Value3?.RepoData?.Id;
            Console.WriteLine($"  {id}");
        }

        spaces.RecentlyTrending.Should().NotBeEmpty();
    }
}
