#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Start a job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response169> CreateJobsByNamespaceAsync(
            string @namespace,

            global::HuggingFace.Request87 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start a job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="spaceId"></param>
        /// <param name="dockerImage"></param>
        /// <param name="arguments"></param>
        /// <param name="command"></param>
        /// <param name="environment">
        /// Default Value: {}
        /// </param>
        /// <param name="secrets"></param>
        /// <param name="flavor"></param>
        /// <param name="arch"></param>
        /// <param name="timeoutSeconds">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="attempts">
        /// Max number of attempts to make. For example, if you set this to 3, the job will be retried up to 2 times if it fails.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="labels">
        /// Labels for the job as key-value pairs. Both keys and values must be max 100 characters and contain only alphanumeric characters, dots, dashes, and underscores.
        /// </param>
        /// <param name="volumes">
        /// HuggingFace Buckets or Repos to mount as volumes in the job container.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response169> CreateJobsByNamespaceAsync(
            string @namespace,
            global::HuggingFace.RequestFlavor flavor,
            string? spaceId = default,
            string? dockerImage = default,
            global::System.Collections.Generic.IList<string>? arguments = default,
            global::System.Collections.Generic.IList<string>? command = default,
            global::System.Collections.Generic.Dictionary<string, string>? environment = default,
            global::System.Collections.Generic.Dictionary<string, string>? secrets = default,
            global::HuggingFace.RequestArch? arch = default,
            int? timeoutSeconds = default,
            int? attempts = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestVolume>? volumes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}