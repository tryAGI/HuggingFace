
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2
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
    public static class CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Academia => "academia",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Plus => "plus",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Academia,
                "enterprise" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Plus,
                "team" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Team,
                _ => null,
            };
        }
    }
}