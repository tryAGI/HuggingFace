
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// We have open endpoints that you can use to retrieve information from the Hub as well as perform certain actions such as creating model, dataset or Space repos. We offer a wrapper Python client, [`huggingface_hub`](https://github.com/huggingface/huggingface_hub), and a JS client, [`huggingface.js`](https://github.com/huggingface/huggingface.js), that allow easy access to these endpoints. We also provide [webhooks](https://huggingface.co/docs/hub/webhooks) to receive real-time incremental info about repos. Enjoy!<br/>
    /// The base URL for those endpoints below is `https://huggingface.co`. For example, to construct the `/api/models` call below, one can call the URL [https://huggingface.co/api/models](https://huggingface.co/api/models).<br/>
    /// If you're an Agent, you might prefer the [markdown version OpenAPI spec](https://huggingface.co/.well-known/openapi.md).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IHuggingFaceClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// Agentic Provisioning
        /// </summary>
        public AgenticProvisioningClient AgenticProvisioning { get; }

        /// <summary>
        /// Auth
        /// </summary>
        public AuthClient Auth { get; }

        /// <summary>
        /// Buckets
        /// </summary>
        public BucketsClient Buckets { get; }

        /// <summary>
        /// Collections
        /// </summary>
        public CollectionsClient Collections { get; }

        /// <summary>
        /// Datasets
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// Discussions
        /// </summary>
        public DiscussionsClient Discussions { get; }

        /// <summary>
        /// Documentation
        /// </summary>
        public DocsClient Docs { get; }

        /// <summary>
        /// Inference Endpoints
        /// </summary>
        public InferenceEndpointsClient InferenceEndpoints { get; }

        /// <summary>
        /// Jobs
        /// </summary>
        public JobsClient Jobs { get; }

        /// <summary>
        /// Kernels
        /// </summary>
        public KernelsClient Kernels { get; }

        /// <summary>
        /// Models
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// Notifications
        /// </summary>
        public NotificationsClient Notifications { get; }

        /// <summary>
        /// OAuth
        /// </summary>
        public OauthClient Oauth { get; }

        /// <summary>
        /// Organizations
        /// </summary>
        public OrgsClient Orgs { get; }

        /// <summary>
        /// Paper pages
        /// </summary>
        public PapersClient Papers { get; }

        /// <summary>
        /// Repository Search
        /// </summary>
        public RepoSearchClient RepoSearch { get; }

        /// <summary>
        /// Repositories
        /// </summary>
        public ReposClient Repos { get; }

        /// <summary>
        /// Resource groups
        /// </summary>
        public ResourceGroupsClient ResourceGroups { get; }

        /// <summary>
        /// SCIM
        /// </summary>
        public ScimClient Scim { get; }

        /// <summary>
        /// Spaces
        /// </summary>
        public SpacesClient Spaces { get; }

        /// <summary>
        /// SQL Console
        /// </summary>
        public SqlConsoleClient SqlConsole { get; }

        /// <summary>
        /// Users
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// Webhooks
        /// </summary>
        public WebhooksClient Webhooks { get; }

    }
}