
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan
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
    public static class ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan.Team => "team",
                ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}