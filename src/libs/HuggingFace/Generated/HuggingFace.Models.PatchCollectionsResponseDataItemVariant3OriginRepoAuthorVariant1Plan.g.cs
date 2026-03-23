
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan
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
    public static class PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Academia => "academia",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Enterprise => "enterprise",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Plus => "plus",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Academia,
                "enterprise" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Enterprise,
                "plus" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Plus,
                "team" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}