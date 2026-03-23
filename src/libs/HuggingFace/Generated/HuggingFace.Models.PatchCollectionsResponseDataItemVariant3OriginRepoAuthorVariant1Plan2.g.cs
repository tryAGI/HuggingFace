
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2
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
    public static class PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2.Academia => "academia",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2.Enterprise => "enterprise",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2.Plus => "plus",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2.Academia,
                "enterprise" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2.Enterprise,
                "plus" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2.Plus,
                "team" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2.Team,
                _ => null,
            };
        }
    }
}