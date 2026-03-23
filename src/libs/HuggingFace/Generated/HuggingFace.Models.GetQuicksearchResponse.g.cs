
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetQuicksearchResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseDataset> Datasets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DatasetsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseModel> Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ModelsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseOrg> Orgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Q { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseSpace> Spaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spacesCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SpacesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseUser> Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("papers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponsePaper> Papers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("papersCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PapersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseCollection> Collections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CollectionsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseBucket> Buckets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BucketsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetQuicksearchResponse" /> class.
        /// </summary>
        /// <param name="datasets"></param>
        /// <param name="datasetsCount"></param>
        /// <param name="models"></param>
        /// <param name="modelsCount"></param>
        /// <param name="orgs"></param>
        /// <param name="q"></param>
        /// <param name="spaces"></param>
        /// <param name="spacesCount"></param>
        /// <param name="users"></param>
        /// <param name="papers"></param>
        /// <param name="papersCount"></param>
        /// <param name="collections"></param>
        /// <param name="collectionsCount"></param>
        /// <param name="buckets"></param>
        /// <param name="bucketsCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetQuicksearchResponse(
            global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseDataset> datasets,
            double datasetsCount,
            global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseModel> models,
            double modelsCount,
            global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseOrg> orgs,
            string q,
            global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseSpace> spaces,
            double spacesCount,
            global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseUser> users,
            global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponsePaper> papers,
            double papersCount,
            global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseCollection> collections,
            double collectionsCount,
            global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseBucket> buckets,
            double bucketsCount)
        {
            this.Datasets = datasets ?? throw new global::System.ArgumentNullException(nameof(datasets));
            this.DatasetsCount = datasetsCount;
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.ModelsCount = modelsCount;
            this.Orgs = orgs ?? throw new global::System.ArgumentNullException(nameof(orgs));
            this.Q = q ?? throw new global::System.ArgumentNullException(nameof(q));
            this.Spaces = spaces ?? throw new global::System.ArgumentNullException(nameof(spaces));
            this.SpacesCount = spacesCount;
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Papers = papers ?? throw new global::System.ArgumentNullException(nameof(papers));
            this.PapersCount = papersCount;
            this.Collections = collections ?? throw new global::System.ArgumentNullException(nameof(collections));
            this.CollectionsCount = collectionsCount;
            this.Buckets = buckets ?? throw new global::System.ArgumentNullException(nameof(buckets));
            this.BucketsCount = bucketsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetQuicksearchResponse" /> class.
        /// </summary>
        public GetQuicksearchResponse()
        {
        }
    }
}