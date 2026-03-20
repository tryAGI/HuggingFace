
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response121
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseDataset2> Datasets { get; set; }

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
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseModel2> Models { get; set; }

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
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseOrg6> Orgs { get; set; }

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
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseSpace2> Spaces { get; set; }

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
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseUser7> Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("papers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponsePaper2> Papers { get; set; }

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
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseCollection2> Collections { get; set; }

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
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseBucket2> Buckets { get; set; }

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
        /// Initializes a new instance of the <see cref="Response121" /> class.
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
        public Response121(
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseDataset2> datasets,
            double datasetsCount,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseModel2> models,
            double modelsCount,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseOrg6> orgs,
            string q,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseSpace2> spaces,
            double spacesCount,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseUser7> users,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponsePaper2> papers,
            double papersCount,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseCollection2> collections,
            double collectionsCount,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseBucket2> buckets,
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
        /// Initializes a new instance of the <see cref="Response121" /> class.
        /// </summary>
        public Response121()
        {
        }
    }
}