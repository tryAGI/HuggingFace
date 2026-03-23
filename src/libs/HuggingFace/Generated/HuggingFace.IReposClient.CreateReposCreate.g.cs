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
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateReposCreateResponse> CreateReposCreateAsync(

            global::HuggingFace.AllOf<global::HuggingFace.CreateReposCreateRequest2, global::HuggingFace.AnyOf<global::HuggingFace.CreateReposCreateRequestVariant1, global::HuggingFace.CreateReposCreateRequestVariant22, global::HuggingFace.CreateReposCreateRequestVariant3, global::HuggingFace.CreateReposCreateRequestVariant4>?> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new repository
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateReposCreateResponse> CreateReposCreateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}