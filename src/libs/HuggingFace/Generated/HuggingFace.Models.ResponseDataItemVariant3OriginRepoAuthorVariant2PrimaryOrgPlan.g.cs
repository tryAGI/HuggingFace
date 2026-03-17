
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
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
        Academia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Team => "team",
                ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}