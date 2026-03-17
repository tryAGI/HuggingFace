namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task WhoAmI()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Auth.GetWhoamiV2Async();
        response.Should().NotBeNull();

        Console.WriteLine($"User: {response}");
    }
}
