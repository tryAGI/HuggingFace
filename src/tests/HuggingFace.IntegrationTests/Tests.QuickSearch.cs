namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task QuickSearch_ModelsAsync()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.RepoSearch.CreateQuicksearchAsync(
            request: new Request45
            {
                Q = "llama",
                Limit = 3,
                Exclude = [],
            });

        response.Models.Should().NotBeEmpty();
        response.ModelsCount.Should().BeGreaterThan(0);
        response.Models.First().Id.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task QuickSearch_DatasetsAndSpacesAsync()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.RepoSearch.CreateQuicksearchAsync(
            request: new Request45
            {
                Q = "image classification",
                Limit = 5,
                Exclude = [],
            });

        (response.DatasetsCount + response.SpacesCount).Should().BeGreaterThan(0);
    }

    [TestMethod]
    public async Task QuickSearch_PapersAsync()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.RepoSearch.CreateQuicksearchAsync(
            request: new Request45
            {
                Q = "attention mechanism",
                Limit = 3,
                Exclude = [],
            });

        response.PapersCount.Should().BeGreaterThan(0);
        response.Papers.Should().NotBeEmpty();
        response.Papers.First().Id.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task QuickSearch_WithExcludeAsync()
    {
        using var client = GetAuthenticatedClient();

        var baseline = await client.RepoSearch.CreateQuicksearchAsync(
            request: new Request45
            {
                Q = "bert",
                Limit = 3,
                Exclude = [],
            });

        var firstModelId = baseline.Models.First().Id;

        var filtered = await client.RepoSearch.CreateQuicksearchAsync(
            request: new Request45
            {
                Q = "bert",
                Limit = 3,
                Exclude = [$"models/{firstModelId}"],
            });

        filtered.Models.Select(m => m.Id).Should().NotContain(firstModelId);
    }
}
