#nullable enable

namespace HuggingFace
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Follow changes<br/>
        /// Server-sent events (`Accept: text/event-stream`) of the bucket's file changes, so clients can stop polling `/tree`.<br/>
        /// Events:<br/>
        /// - `ready`: `{"cursor"}` — replay (if any) is done, live changes follow. `cursor` may be absent if the feed has seen no change yet.<br/>
        /// - `changes`: `{"cursor", "changes": [{"path", "op": "add" | "update" | "delete", "size"?, "xetHash"?, "uploadedAt"?, "mtime"?, "mtimeNanos"?}]}` — a batch of changes coalesced over ~200ms. An `update` only carries the fields that changed (an identical re-upload has just `uploadedAt`); `mtime`/`mtimeNanos` are `null` when a re-upload cleared them. `xetHash` is omitted without content read access.<br/>
        /// - `reset`: `{"reason": "cursor_too_old"}` — the requested `cursor`/`since` is older than what the server buffers (about 15 minutes); the stream ends and the client must re-list.<br/>
        /// - `reconnect`: `{"cursor"}` — sent after 20 minutes or when the server shuts down (deploys), then the stream ends; reconnect with that cursor. Treat any other end of the stream the same way: reconnect with the last cursor you received.<br/>
        /// A `: ping` comment is sent every 30s. Resume with `?cursor=` (exclusive) or `?since=` (inclusive); without either, only live changes are sent.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cursor">
        /// Opaque cursor from a previous `ready`/`changes` event; resume after it
        /// </param>
        /// <param name="since">
        /// Resume from this instant instead of a cursor (e.g. the bucket's `updatedAt` you last saw)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetBucketsByNamespaceByRepoEventsAsync(
            string @namespace,
            string repo,
            string? cursor = default,
            global::System.DateTime? since = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Follow changes<br/>
        /// Server-sent events (`Accept: text/event-stream`) of the bucket's file changes, so clients can stop polling `/tree`.<br/>
        /// Events:<br/>
        /// - `ready`: `{"cursor"}` — replay (if any) is done, live changes follow. `cursor` may be absent if the feed has seen no change yet.<br/>
        /// - `changes`: `{"cursor", "changes": [{"path", "op": "add" | "update" | "delete", "size"?, "xetHash"?, "uploadedAt"?, "mtime"?, "mtimeNanos"?}]}` — a batch of changes coalesced over ~200ms. An `update` only carries the fields that changed (an identical re-upload has just `uploadedAt`); `mtime`/`mtimeNanos` are `null` when a re-upload cleared them. `xetHash` is omitted without content read access.<br/>
        /// - `reset`: `{"reason": "cursor_too_old"}` — the requested `cursor`/`since` is older than what the server buffers (about 15 minutes); the stream ends and the client must re-list.<br/>
        /// - `reconnect`: `{"cursor"}` — sent after 20 minutes or when the server shuts down (deploys), then the stream ends; reconnect with that cursor. Treat any other end of the stream the same way: reconnect with the last cursor you received.<br/>
        /// A `: ping` comment is sent every 30s. Resume with `?cursor=` (exclusive) or `?since=` (inclusive); without either, only live changes are sent.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cursor">
        /// Opaque cursor from a previous `ready`/`changes` event; resume after it
        /// </param>
        /// <param name="since">
        /// Resume from this instant instead of a cursor (e.g. the bucket's `updatedAt` you last saw)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> GetBucketsByNamespaceByRepoEventsAsResponseAsync(
            string @namespace,
            string repo,
            string? cursor = default,
            global::System.DateTime? since = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}