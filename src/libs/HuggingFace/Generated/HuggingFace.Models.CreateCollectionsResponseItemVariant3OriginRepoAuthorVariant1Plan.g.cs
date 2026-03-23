
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan
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
    public static class CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Academia => "academia",
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Enterprise => "enterprise",
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Plus => "plus",
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Academia,
                "enterprise" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Enterprise,
                "plus" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Plus,
                "team" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}