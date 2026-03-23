
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan
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
    public static class GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Plus,
                "team" => GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}