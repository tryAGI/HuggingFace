
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
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
        Academia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Team => "team",
                ResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}