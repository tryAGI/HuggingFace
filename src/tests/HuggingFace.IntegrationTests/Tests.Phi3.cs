namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetModelTags()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Models.GetModelsTagsByTypeAsync();
        response.Should().NotBeNull();
        response.Should().NotBeEmpty();

        foreach (var (tagType, tags) in response)
        {
            Console.WriteLine($"{tagType}: {tags.Count} tags");
        }
    }
}
