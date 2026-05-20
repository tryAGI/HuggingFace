
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan
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
    public static class GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan.Plus,
                "team" => GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}