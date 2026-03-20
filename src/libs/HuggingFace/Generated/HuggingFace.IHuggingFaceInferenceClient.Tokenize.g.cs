#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceInferenceClient
    {
        /// <summary>
        /// Tokenize inputs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.SimpleToken>> TokenizeAsync(

            global::HuggingFace.GenerateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tokenize inputs
        /// </summary>
        /// <param name="inputs">
        /// Example: My name is Olivier and I
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.SimpleToken>> TokenizeAsync(
            string inputs,
            global::HuggingFace.GenerateParameters? parameters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}