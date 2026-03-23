
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan
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
    public static class GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Academia => "academia",
                GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Enterprise => "enterprise",
                GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Plus => "plus",
                GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Academia,
                "enterprise" => GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Enterprise,
                "plus" => GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Plus,
                "team" => GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}