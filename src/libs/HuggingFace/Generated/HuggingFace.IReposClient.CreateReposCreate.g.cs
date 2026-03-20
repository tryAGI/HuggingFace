#nullable enable

namespace HuggingFace
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create a new repository
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response123> CreateReposCreateAsync(

            global::HuggingFace.AllOf<global::HuggingFace.Request64, global::HuggingFace.AnyOf<global::HuggingFace.RequestVariant1, global::HuggingFace.RequestVariant22, global::HuggingFace.RequestVariant3, global::HuggingFace.RequestVariant4>?> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new repository
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response123> CreateReposCreateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}