
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan
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
    public static class GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Plus,
                "team" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}