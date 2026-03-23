
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2
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
    public static class CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2.Academia => "academia",
                CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2.Enterprise => "enterprise",
                CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2.Plus => "plus",
                CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2.Academia,
                "enterprise" => CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2.Enterprise,
                "plus" => CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2.Plus,
                "team" => CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2.Team,
                _ => null,
            };
        }
    }
}