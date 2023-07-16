using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;

#pragma warning disable CA1822

namespace tryAGI.OpenAI;

public partial class OpenAiApi
{
    partial void UpdateJsonSerializerSettings(JsonSerializerOptions settings)
    {
        // Bug, does not work.
        // https://github.com/RicoSuter/NSwag/issues/4460
        settings.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
    }

    // ReSharper disable UnusedParameter.Local
    // ReSharper disable MemberCanBeMadeStatic.Local
    private async Task PrepareRequestAsync(HttpClient client, HttpRequestMessage request, string url, CancellationToken cancellationToken)
    {
        if (request.Content is not StringContent stringContent)
        {
            return;
        }
        
#if NET6_0_OR_GREATER
        var json = await stringContent.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        
        request.Content = new StringContent(json
            .Replace(@"""role"":""System""", @"""role"":""system""", StringComparison.Ordinal)
            .Replace(@"""role"":""User""", @"""role"":""user""", StringComparison.Ordinal)
            .Replace(@"""role"":""Assistant""", @"""role"":""assistant""", StringComparison.Ordinal)
            .Replace(@"""role"":""Function""", @"""role"":""function""", StringComparison.Ordinal)
            .Replace(@"""function_call"":""Auto""", @"""function_call"":""auto""", StringComparison.Ordinal));
#else
        var json = await stringContent.ReadAsStringAsync().ConfigureAwait(false);
        
        request.Content = new StringContent(json
            .Replace(@"""role"":""System""", @"""role"":""system""")
            .Replace(@"""role"":""User""", @"""role"":""user""")
            .Replace(@"""role"":""Assistant""", @"""role"":""assistant""")
            .Replace(@"""role"":""Function""", @"""role"":""function""")
            .Replace(@"""function_call"":""Auto""", @"""function_call"":""auto"""));
#endif
        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
    }
    
    private Task PrepareRequestAsync(HttpClient client, HttpRequestMessage request, StringBuilder builder, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
    
    private Task ProcessResponseAsync(HttpClient client, HttpResponseMessage message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
