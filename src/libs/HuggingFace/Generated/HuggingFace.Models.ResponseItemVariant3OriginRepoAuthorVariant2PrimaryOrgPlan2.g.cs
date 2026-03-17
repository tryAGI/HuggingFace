
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2
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
    public static class ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Team => "team",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Plus => "plus",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Team,
                "enterprise" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Plus,
                "academia" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Academia,
                _ => null,
            };
        }
    }
}