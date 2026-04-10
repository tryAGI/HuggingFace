
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
    public sealed partial class HuggingFaceClient : global::HuggingFace.IHuggingFaceClient, global::System.IDisposable
    {
        /// <summary>
        /// Hub
        /// </summary>
        public const string DefaultBaseUrl = "https://huggingface.co/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::HuggingFace.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::HuggingFace.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::HuggingFace.SourceGenerationContext.Default;


        /// <summary>
        /// Agentic Provisioning. The following endpoints are for use with Agentic Provisioning Protocol.
        /// </summary>
        public AgenticProvisioningClient AgenticProvisioning => new AgenticProvisioningClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Auth. The following endpoints get information about your currently used user based on the passed token.
        /// </summary>
        public AuthClient Auth => new AuthClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Buckets. Git-free storage buckets for files, powered by Xet. Buckets provide simple file storage without git versioning.
        /// </summary>
        public BucketsClient Buckets => new BucketsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Collections. Use Collections to group repositories from the Hub (Models, Datasets, Spaces and Papers) on a dedicated page.<br/>
        /// You can learn more about it in the Collections [guide](https://huggingface.co/docs/hub/collections). Collections can also be managed using the Python client (see [guide](https://huggingface.co/docs/huggingface_hub/main/en/guides/collections)).
        /// </summary>
        public CollectionsClient Collections => new CollectionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Datasets. Get information from all datasets on the Hub.
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Discussions. The following endpoints manage discussions.
        /// </summary>
        public DiscussionsClient Discussions => new DiscussionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Documentation. The following endpoints are for interacting with the Hub's documentation.
        /// </summary>
        public DocsClient Docs => new DocsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Inference Endpoints. Manage inference endpoints.
        /// </summary>
        public InferenceEndpointsClient InferenceEndpoints => new InferenceEndpointsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Jobs. The following endpoints manage jobs.
        /// </summary>
        public JobsClient Jobs => new JobsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Kernels. Get information from all kernels on the Hub.
        /// </summary>
        public KernelsClient Kernels => new KernelsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Models. Get information from all models on the Hub.
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Notifications. The following endpoints fetch Hub notifications.
        /// </summary>
        public NotificationsClient Notifications => new NotificationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// OAuth. The following endpoints are for use with OAuth.
        /// </summary>
        public OauthClient Oauth => new OauthClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Organizations. The following endpoints let you interact with Hub Organizations and their members.
        /// </summary>
        public OrgsClient Orgs => new OrgsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Paper pages. The following endpoint gets information about papers.
        /// </summary>
        public PapersClient Papers => new PapersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Repository Search. The following endpoints help get information about models, datasets, and Spaces stored on the Hub.
        /// </summary>
        public RepoSearchClient RepoSearch => new RepoSearchClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Repositories. The following endpoints manage repository settings like creating and deleting a repository.
        /// </summary>
        public ReposClient Repos => new ReposClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Resource groups. The following endpoints manage resource groups. Resource groups are a Team or Enterprise feature.
        /// </summary>
        public ResourceGroupsClient ResourceGroups => new ResourceGroupsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// SCIM. Use the SCIM API to control and manage your hub Enterprise organization manage members' access.<br/>
        /// ## Authentication<br/>
        /// - Must be organization owner<br/>
        /// - Use Access token with write permission on organization<br/>
        /// - Organization must be Enterprise Plus<br/>
        /// ## Key Attribute Matching<br/>
        /// - Microsoft Entra ID (Azure AD)<br/>
        /// 	* SAML: `http://schemas.microsoft.com/identity/claims/objectidentifier`<br/>
        /// 	* SCIM: `externalId`<br/>
        /// - Other Identity Providers<br/>
        /// 	* SAML: `NameID` or `unique identifier`<br/>
        /// 	* SCIM: `externalId`<br/>
        /// ## Supported SCIM User Attributes<br/>
        /// | Attribute | Description |<br/>
        /// |---|---|<br/>
        /// | `userName` | Username for the user |<br/>
        /// | `name.givenName` | First name |<br/>
        /// | `name.familyName` | Last name |<br/>
        /// | `emails` | Array of user emails; we don't support email types |<br/>
        /// | `externalId` | IDP provider's unique identifier |<br/>
        /// | `id` | Hugging Face SCIM endpoint identifier |<br/>
        /// | `active` | Boolean for provisioning status |.
        /// </summary>
        public ScimClient Scim => new ScimClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Spaces. Get information from all Spaces on the Hub.
        /// </summary>
        public SpacesClient Spaces => new SpacesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// SQL Console. Get information from SQL Console embeds from a dataset.
        /// </summary>
        public SqlConsoleClient SqlConsole => new SqlConsoleClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Users. User accounts are the base authoring entity on the Hub.
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Webhooks. The following endpoints are for use with webhooks.
        /// </summary>
        public WebhooksClient Webhooks => new WebhooksClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the HuggingFaceClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public HuggingFaceClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::HuggingFace.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the HuggingFaceClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public HuggingFaceClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::HuggingFace.EndPointAuthorization>? authorizations = null,
            global::HuggingFace.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::HuggingFace.EndPointAuthorization>();
            Options = options ?? new global::HuggingFace.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}