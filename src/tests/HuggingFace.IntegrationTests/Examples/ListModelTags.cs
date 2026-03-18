/*
order: 120
title: List Model Tags
slug: list-model-tags

List available model tags grouped by type from the HuggingFace Hub.
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListModelTags()
    {
        var apiKey = GetApiKey();
        using var client = new HuggingFaceClient(apiKey);

        var tags = await client.Models.GetModelsTagsByTypeAsync();

        foreach (var (tagType, tagList) in tags)
        {
            Console.WriteLine($"{tagType}: {tagList.Count} tags");
        }

        tags.Should().NotBeEmpty();
    }
}
