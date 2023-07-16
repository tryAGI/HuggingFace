using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace tryAGI.OpenAI;

public partial class OpenAiApi
{
    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Creates a model response for the given chat conversation.
    /// </summary>
    /// <returns>OK</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async IAsyncEnumerable<CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
        CreateChatCompletionRequest body,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        body = body ?? throw new ArgumentNullException(nameof(body));
        body.Stream = true;
        
        var urlBuilder = new System.Text.StringBuilder();
        urlBuilder.Append(BaseUrl.TrimEnd('/')).Append("/chat/completions");

        var url = urlBuilder.ToString();
        
        using var request = new HttpRequestMessage(HttpMethod.Post, new Uri(url, UriKind.RelativeOrAbsolute))
        {
            Content = new StringContent(JsonSerializer.Serialize(body, _settings.Value))
            {
                Headers =
                {
                    ContentType = MediaTypeHeaderValue.Parse("application/json"),
                }
            },
            Headers =
            {
                Accept =
                {
                    MediaTypeWithQualityHeaderValue.Parse("text/event-stream"),
                },
            }
        };

        await PrepareRequestAsync(_httpClient, request, urlBuilder, cancellationToken).ConfigureAwait(false);
        await PrepareRequestAsync(_httpClient, request, url, cancellationToken).ConfigureAwait(false);

        using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
        var headers = response.Headers.ToDictionary(
            static h => h.Key,
            static h => h.Value);
        foreach (var pair in response.Content.Headers)
        {
            headers[pair.Key] = pair.Value;
        }

        await ProcessResponseAsync(_httpClient, response, cancellationToken).ConfigureAwait(false);

        var status = (int)response.StatusCode;
        if (status != 200)
        {
#if NET6_0_OR_GREATER
            var responseData = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
#else
            var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
#endif
            
            throw new ApiException(
                "The HTTP status code of the response was not expected (" + status + ").",
                status,
                responseData,
                headers,
                null);
        }

#if NET6_0_OR_GREATER
        using var responseStream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#else
        using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
#endif
        using var reader = new StreamReader(responseStream);

        // Continuously read the stream until the end of it
        while (!reader.EndOfStream)
        {
            cancellationToken.ThrowIfCancellationRequested();

#if NET7_0_OR_GREATER
            var line = await reader.ReadLineAsync(cancellationToken).ConfigureAwait(false);
#else
            var line = await reader.ReadLineAsync().ConfigureAwait(false);
#endif
            
            // Skip empty lines
            if (string.IsNullOrEmpty(line))
            {
                continue;
            }

            var index = line.IndexOf("{", StringComparison.Ordinal);
            if (index >= 0)
            {
                line = line[index..];
            }

            // Exit the loop if the stream is done
            if (line.StartsWith("data: [DONE]", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            CreateChatCompletionStreamResponse? block;
            try
            {
                // When the response is good, each line is a serializable CompletionCreateRequest
                block = JsonSerializer.Deserialize<CreateChatCompletionStreamResponse>(line);
            }
            catch (JsonException)
            {
                // When the API returns an error, it does not come back as a block, it returns a single character of text ("{").
                // In this instance, read through the rest of the response, which should be a complete object to parse.
#if NET7_0_OR_GREATER
                line += await reader.ReadToEndAsync(cancellationToken).ConfigureAwait(false);
#else
                line += await reader.ReadToEndAsync().ConfigureAwait(false);
#endif
                block = JsonSerializer.Deserialize<CreateChatCompletionStreamResponse>(line);
            }

            if (block == null)
            {
                throw new ApiException("Response was null which was not expected.", status, line, headers, null);
            }
            
            yield return block;
        }
    }
}
