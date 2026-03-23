
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2
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
    public static class GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2.Academia => "academia",
                GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2.Plus => "plus",
                GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2.Academia,
                "enterprise" => GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2.Plus,
                "team" => GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2.Team,
                _ => null,
            };
        }
    }
}