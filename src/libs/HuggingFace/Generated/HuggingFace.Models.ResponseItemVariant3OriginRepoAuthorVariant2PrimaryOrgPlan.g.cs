
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan
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
    public static class ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Team => "team",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}