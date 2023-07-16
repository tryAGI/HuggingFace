using System.Net.Http.Headers;

namespace tryAGI.OpenAI;

/// <summary>
/// Class providing methods for API access.
/// </summary>
public partial class OpenAiApi
{
    /// <summary>
    /// Sets the selected apiKey as a default header for the HttpClient.
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="httpClient"></param>
    public OpenAiApi(string apiKey, HttpClient httpClient) : this(httpClient)
    {
        apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            scheme: "Bearer",
            parameter: apiKey);
    }
}
