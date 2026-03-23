
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan
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
    public static class CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Academia => "academia",
                CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Plus => "plus",
                CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Plus,
                "team" => CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}