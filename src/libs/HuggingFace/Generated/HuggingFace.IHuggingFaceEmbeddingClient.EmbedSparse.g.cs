#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceEmbeddingClient
    {
        /// <summary>
        /// Get Sparse Embeddings. Returns a 424 status code if the model is not an embedding model with SPLADE pooling.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.SparseValue>>> EmbedSparseAsync(

            global::HuggingFace.EmbedSparseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Sparse Embeddings. Returns a 424 status code if the model is not an embedding model with SPLADE pooling.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="promptName">
        /// The name of the prompt that should be used by for encoding. If not set, no prompt<br/>
        /// will be applied.<br/>
        /// Must be a key in the `sentence-transformers` configuration `prompts` dictionary.<br/>
        /// For example if ``prompt_name`` is "query" and the ``prompts`` is {"query": "query: ", ...},<br/>
        /// then the sentence "What is the capital of France?" will be encoded as<br/>
        /// "query: What is the capital of France?" because the prompt text will be prepended before<br/>
        /// any text to encode.<br/>
        /// Default Value: null<br/>
        /// Example: null
        /// </param>
        /// <param name="truncate">
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="truncationDirection">
        /// Default Value: right
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::HuggingFace.SparseValue>>> EmbedSparseAsync(
            global::HuggingFace.Input inputs,
            string? promptName = default,
            bool? truncate = default,
            global::HuggingFace.TruncationDirection? truncationDirection = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}