#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceEmbeddingClient
    {

        /// <summary>
        /// Decode input ids
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> DecodeAsync(

            global::HuggingFace.DecodeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Decode input ids
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="skipSpecialTokens">
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> DecodeAsync(
            global::HuggingFace.InputIds ids,
            bool? skipSpecialTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}