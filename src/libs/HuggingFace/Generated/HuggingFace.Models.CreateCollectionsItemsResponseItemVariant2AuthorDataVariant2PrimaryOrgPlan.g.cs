
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan
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
    public static class CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Plus,
                "team" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}