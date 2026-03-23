
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2
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
    public static class CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2.Academia => "academia",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2.Plus => "plus",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2.Academia,
                "enterprise" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2.Plus,
                "team" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2.Team,
                _ => null,
            };
        }
    }
}