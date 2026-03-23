
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan
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
    public static class CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Academia,
                "enterprise" => CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Plus,
                "team" => CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}