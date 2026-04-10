#nullable enable

namespace HuggingFace
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Commit<br/>
        /// For legacy reason, we support both `application/json` and `application/x-ndjson` but we recommend using `application/x-ndjson` to create a commit.<br/>
        /// JSON-lines payload:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "key": "header",<br/>
        ///   "value": {<br/>
        ///     "summary": "string (REQUIRED)",<br/>
        ///     "description": "string (OPTIONAL - defaults to empty string)",<br/>
        ///     "parentCommit": "string (OPTIONAL - 40-character hex SHA)"<br/>
        ///   }<br/>
        /// }<br/>
        /// {<br/>
        ///   "key": "file", <br/>
        ///   "value": {<br/>
        ///     "path": "string (REQUIRED)",<br/>
        ///     "content": "string (OPTIONAL - required if oldPath not set)",<br/>
        ///     "encoding": "utf-8 | base64 (OPTIONAL - defaults to utf-8)",<br/>
        ///     "oldPath": "string (OPTIONAL - for move/rename operations)"<br/>
        ///   }<br/>
        /// }<br/>
        /// {<br/>
        ///   "key": "deletedEntry",<br/>
        ///   "value": {<br/>
        ///     "path": "string (REQUIRED)"<br/>
        ///   }<br/>
        /// }<br/>
        /// {<br/>
        ///   "key": "lfsFile",<br/>
        ///   "value": {<br/>
        ///     "path": "string (REQUIRED - max 1000 chars)",<br/>
        ///     "oid": "string (OPTIONAL - required if oldPath not set, 64 hex chars)",<br/>
        ///     "algo": "sha256 (OPTIONAL - only sha256 supported)",<br/>
        ///     "size": "number (OPTIONAL - required if oldPath is set)",<br/>
        ///     "oldPath": "string (OPTIONAL - for move/rename operations)"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// JSON payload:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "summary": "string (REQUIRED)",<br/>
        ///   "description": "string (OPTIONAL - defaults to empty string)",<br/>
        ///   "parentCommit": "string (OPTIONAL - 40-character hex SHA)"<br/>
        ///   "files": [<br/>
        ///     {<br/>
        ///       "path": "string (REQUIRED)",<br/>
        ///       "content": "string (OPTIONAL - required if oldPath not set)",<br/>
        ///       "encoding": "utf-8 | base64 (OPTIONAL - defaults to utf-8)",<br/>
        ///       "oldPath": "string (OPTIONAL - for move/rename operations)"<br/>
        ///     }<br/>
        ///   ],<br/>
        ///   "deletedEntries": [<br/>
        ///     {<br/>
        ///       "path": "string (REQUIRED)"<br/>
        ///     }<br/>
        ///   ],<br/>
        ///   "lfsFiles": [<br/>
        ///     {<br/>
        ///       "path": "string (REQUIRED - max 1000 chars)",<br/>
        ///       "oid": "string (OPTIONAL - required if oldPath not set, 64 hex chars)",<br/>
        ///       "algo": "sha256 (OPTIONAL - only sha256 supported)",<br/>
        ///       "size": "number (OPTIONAL - required if oldPath is set)",<br/>
        ///       "oldPath": "string (OPTIONAL - for move/rename operations)"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="createPr">
        /// Whether to create a pull request from the commit
        /// </param>
        /// <param name="hotReload">
        /// For Spaces, whether to try to hot reload the commit (only for single python files updates)
        /// </param>
        /// <param name="contentType">
        /// `application/x-ndjson` if you to commit by json lines<br/>
        /// Default Value: application/x-ndjson
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateDatasetsCommitResponse> CreateDatasetsByNamespaceByRepoCommitByRevAsync(
            string @namespace,
            string repo,
            string rev,
            object? createPr = default,
            object? hotReload = default,
            global::HuggingFace.CreateDatasetsCommitContentType? contentType = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}