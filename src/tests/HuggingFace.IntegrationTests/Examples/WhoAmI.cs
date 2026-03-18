/*
order: 100
title: Who Am I
slug: who-am-i

Get the authenticated user's account information using the Hub API.
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_WhoAmI()
    {
        var apiKey = GetApiKey();
        using var client = new HuggingFaceClient(apiKey);

        var response = await client.Auth.GetWhoamiV2Async();

        Console.WriteLine($"User: {response}");

        response.Should().NotBeNull();
    }
}
