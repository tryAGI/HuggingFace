
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan
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
    public static class PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Academia,
                "enterprise" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Plus,
                "team" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}