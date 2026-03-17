
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestNotifications
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("announcements")]
        public bool? Announcements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arxiv_paper_activity")]
        public bool? ArxivPaperActivity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_papers_digest")]
        public bool? DailyPapersDigest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions_participating")]
        public bool? DiscussionsParticipating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions_watched")]
        public bool? DiscussionsWatched { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gated_user_access_request")]
        public bool? GatedUserAccessRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_endpoint_status")]
        public bool? InferenceEndpointStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("launch_autonlp")]
        public bool? LaunchAutonlp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("launch_spaces")]
        public bool? LaunchSpaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("launch_prepaid_credits")]
        public bool? LaunchPrepaidCredits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("launch_training_cluster")]
        public bool? LaunchTrainingCluster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_request")]
        public bool? OrgRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_suggestions")]
        public bool? OrgSuggestions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_verified_suggestions")]
        public bool? OrgVerifiedSuggestions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_suggestions_to_create")]
        public bool? OrgSuggestionsToCreate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("posts_participating")]
        public bool? PostsParticipating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_follows")]
        public bool? UserFollows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_detected")]
        public bool? SecretDetected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_discussions_participating")]
        public bool? WebDiscussionsParticipating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_discussions_watched")]
        public bool? WebDiscussionsWatched { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_posts_participating")]
        public bool? WebPostsParticipating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_updates_after")]
        public global::System.DateTime? ProductUpdatesAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_inference_sunset")]
        public bool? ApiInferenceSunset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked_out")]
        public bool? LockedOut { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestNotifications" /> class.
        /// </summary>
        /// <param name="announcements"></param>
        /// <param name="arxivPaperActivity"></param>
        /// <param name="dailyPapersDigest"></param>
        /// <param name="discussionsParticipating"></param>
        /// <param name="discussionsWatched"></param>
        /// <param name="gatedUserAccessRequest"></param>
        /// <param name="inferenceEndpointStatus"></param>
        /// <param name="launchAutonlp"></param>
        /// <param name="launchSpaces"></param>
        /// <param name="launchPrepaidCredits"></param>
        /// <param name="launchTrainingCluster"></param>
        /// <param name="orgRequest"></param>
        /// <param name="orgSuggestions"></param>
        /// <param name="orgVerifiedSuggestions"></param>
        /// <param name="orgSuggestionsToCreate"></param>
        /// <param name="postsParticipating"></param>
        /// <param name="userFollows"></param>
        /// <param name="secretDetected"></param>
        /// <param name="webDiscussionsParticipating"></param>
        /// <param name="webDiscussionsWatched"></param>
        /// <param name="webPostsParticipating"></param>
        /// <param name="productUpdatesAfter"></param>
        /// <param name="apiInferenceSunset"></param>
        /// <param name="lockedOut"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestNotifications(
            bool? announcements,
            bool? arxivPaperActivity,
            bool? dailyPapersDigest,
            bool? discussionsParticipating,
            bool? discussionsWatched,
            bool? gatedUserAccessRequest,
            bool? inferenceEndpointStatus,
            bool? launchAutonlp,
            bool? launchSpaces,
            bool? launchPrepaidCredits,
            bool? launchTrainingCluster,
            bool? orgRequest,
            bool? orgSuggestions,
            bool? orgVerifiedSuggestions,
            bool? orgSuggestionsToCreate,
            bool? postsParticipating,
            bool? userFollows,
            bool? secretDetected,
            bool? webDiscussionsParticipating,
            bool? webDiscussionsWatched,
            bool? webPostsParticipating,
            global::System.DateTime? productUpdatesAfter,
            bool? apiInferenceSunset,
            bool? lockedOut)
        {
            this.Announcements = announcements;
            this.ArxivPaperActivity = arxivPaperActivity;
            this.DailyPapersDigest = dailyPapersDigest;
            this.DiscussionsParticipating = discussionsParticipating;
            this.DiscussionsWatched = discussionsWatched;
            this.GatedUserAccessRequest = gatedUserAccessRequest;
            this.InferenceEndpointStatus = inferenceEndpointStatus;
            this.LaunchAutonlp = launchAutonlp;
            this.LaunchSpaces = launchSpaces;
            this.LaunchPrepaidCredits = launchPrepaidCredits;
            this.LaunchTrainingCluster = launchTrainingCluster;
            this.OrgRequest = orgRequest;
            this.OrgSuggestions = orgSuggestions;
            this.OrgVerifiedSuggestions = orgVerifiedSuggestions;
            this.OrgSuggestionsToCreate = orgSuggestionsToCreate;
            this.PostsParticipating = postsParticipating;
            this.UserFollows = userFollows;
            this.SecretDetected = secretDetected;
            this.WebDiscussionsParticipating = webDiscussionsParticipating;
            this.WebDiscussionsWatched = webDiscussionsWatched;
            this.WebPostsParticipating = webPostsParticipating;
            this.ProductUpdatesAfter = productUpdatesAfter;
            this.ApiInferenceSunset = apiInferenceSunset;
            this.LockedOut = lockedOut;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestNotifications" /> class.
        /// </summary>
        public RequestNotifications()
        {
        }
    }
}