/*
order: 140
title: Error Handling
slug: error-handling

Handle API errors gracefully using the ApiException type.
*/

namespace HuggingFace.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ErrorHandling()
    {
        var apiKey = GetApiKey();
        using var client = new HuggingFaceClient("invalid-api-key");

        try
        {
            await client.Auth.GetWhoamiV2Async();
        }
        catch (ApiException ex)
        {
            Console.WriteLine($"Status: {ex.StatusCode}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"Body: {ex.ResponseBody}");

            ((int)ex.StatusCode).Should().Be(401);
        }
    }
}
