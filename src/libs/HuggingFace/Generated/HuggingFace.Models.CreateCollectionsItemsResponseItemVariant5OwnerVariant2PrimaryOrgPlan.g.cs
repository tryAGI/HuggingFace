
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan
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
    public static class CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Academia => "academia",
                CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Plus => "plus",
                CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Plus,
                "team" => CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}