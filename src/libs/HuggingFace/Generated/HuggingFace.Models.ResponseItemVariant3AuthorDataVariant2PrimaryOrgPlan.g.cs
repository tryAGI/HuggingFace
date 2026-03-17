
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan
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
    public static class ResponseItemVariant3AuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Team => "team",
                ResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}