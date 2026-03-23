
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan
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
    public static class CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan.Academia => "academia",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan.Plus => "plus",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan.Plus,
                "team" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}