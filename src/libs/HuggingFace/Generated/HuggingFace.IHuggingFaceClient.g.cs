
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
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Agentic Provisioning. The following endpoints are for use with Agentic Provisioning Protocol.
        /// </summary>
        public AgenticProvisioningClient AgenticProvisioning { get; }

        /// <summary>
        /// Auth. The following endpoints get information about your currently used user based on the passed token.
        /// </summary>
        public AuthClient Auth { get; }

        /// <summary>
        /// Buckets. Git-free storage buckets for files, powered by Xet. Buckets provide simple file storage without git versioning.
        /// </summary>
        public BucketsClient Buckets { get; }

        /// <summary>
        /// Collections. Use Collections to group repositories from the Hub (Models, Datasets, Spaces and Papers) on a dedicated page.<br/>
        /// You can learn more about it in the Collections [guide](https://huggingface.co/docs/hub/collections). Collections can also be managed using the Python client (see [guide](https://huggingface.co/docs/huggingface_hub/main/en/guides/collections)).
        /// </summary>
        public CollectionsClient Collections { get; }

        /// <summary>
        /// Datasets. Get information from all datasets on the Hub.
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// Discussions. The following endpoints manage discussions.
        /// </summary>
        public DiscussionsClient Discussions { get; }

        /// <summary>
        /// Documentation. The following endpoints are for interacting with the Hub's documentation.
        /// </summary>
        public DocsClient Docs { get; }

        /// <summary>
        /// Inference Endpoints. Manage inference endpoints.
        /// </summary>
        public InferenceEndpointsClient InferenceEndpoints { get; }

        /// <summary>
        /// Jobs. The following endpoints manage jobs.
        /// </summary>
        public JobsClient Jobs { get; }

        /// <summary>
        /// Kernels. Get information from all kernels on the Hub.
        /// </summary>
        public KernelsClient Kernels { get; }

        /// <summary>
        /// Models. Get information from all models on the Hub.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// Notifications. The following endpoints fetch Hub notifications.
        /// </summary>
        public NotificationsClient Notifications { get; }

        /// <summary>
        /// OAuth. The following endpoints are for use with OAuth.
        /// </summary>
        public OauthClient Oauth { get; }

        /// <summary>
        /// Organizations. The following endpoints let you interact with Hub Organizations and their members.
        /// </summary>
        public OrgsClient Orgs { get; }

        /// <summary>
        /// Paper pages. The following endpoint gets information about papers.
        /// </summary>
        public PapersClient Papers { get; }

        /// <summary>
        /// Repository Search. The following endpoints help get information about models, datasets, and Spaces stored on the Hub.
        /// </summary>
        public RepoSearchClient RepoSearch { get; }

        /// <summary>
        /// Repositories. The following endpoints manage repository settings like creating and deleting a repository.
        /// </summary>
        public ReposClient Repos { get; }

        /// <summary>
        /// Resource groups. The following endpoints manage resource groups. Resource groups are a Team or Enterprise feature.
        /// </summary>
        public ResourceGroupsClient ResourceGroups { get; }

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
        public ScimClient Scim { get; }

        /// <summary>
        /// Spaces. Get information from all Spaces on the Hub.
        /// </summary>
        public SpacesClient Spaces { get; }

        /// <summary>
        /// SQL Console. Get information from SQL Console embeds from a dataset.
        /// </summary>
        public SqlConsoleClient SqlConsole { get; }

        /// <summary>
        /// Users. User accounts are the base authoring entity on the Hub.
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// Webhooks. The following endpoints are for use with webhooks.
        /// </summary>
        public WebhooksClient Webhooks { get; }

    }
}