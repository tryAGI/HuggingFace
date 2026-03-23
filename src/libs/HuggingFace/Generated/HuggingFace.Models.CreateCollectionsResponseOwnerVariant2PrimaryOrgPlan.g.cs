
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan
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
    public static class CreateCollectionsResponseOwnerVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan.Academia => "academia",
                CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan.Plus => "plus",
                CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan.Plus,
                "team" => CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}