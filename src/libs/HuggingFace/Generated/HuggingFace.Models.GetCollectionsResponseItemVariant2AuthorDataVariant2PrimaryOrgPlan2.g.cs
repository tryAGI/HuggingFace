
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2
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
    public static class GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Academia => "academia",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Plus => "plus",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Academia,
                "enterprise" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Plus,
                "team" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2.Team,
                _ => null,
            };
        }
    }
}