
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Academia,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}