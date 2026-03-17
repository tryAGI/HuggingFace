
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan4
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
    public static class ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan4 value)
        {
            return value switch
            {
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan4.Team => "team",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan4.Enterprise => "enterprise",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan4.Plus => "plus",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan4.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan4? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan4.Team,
                "enterprise" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan4.Enterprise,
                "plus" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan4.Plus,
                "academia" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan4.Academia,
                _ => null,
            };
        }
    }
}