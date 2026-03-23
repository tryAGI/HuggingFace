
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan
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
    public static class CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Plus,
                "team" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}