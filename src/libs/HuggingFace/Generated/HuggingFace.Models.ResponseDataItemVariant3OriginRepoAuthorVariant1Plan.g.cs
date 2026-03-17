
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3OriginRepoAuthorVariant1Plan
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
    public static class ResponseDataItemVariant3OriginRepoAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3OriginRepoAuthorVariant1Plan value)
        {
            return value switch
            {
                ResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Team => "team",
                ResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Enterprise => "enterprise",
                ResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Plus => "plus",
                ResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3OriginRepoAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Team,
                "enterprise" => ResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Enterprise,
                "plus" => ResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Plus,
                "academia" => ResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}