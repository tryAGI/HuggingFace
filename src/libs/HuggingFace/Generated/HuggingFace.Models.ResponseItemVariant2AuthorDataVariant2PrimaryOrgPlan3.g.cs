
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan3
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
    public static class ResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan3 value)
        {
            return value switch
            {
                ResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan3.Team => "team",
                ResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan3.Enterprise => "enterprise",
                ResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan3.Plus => "plus",
                ResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan3.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan3? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan3.Team,
                "enterprise" => ResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan3.Enterprise,
                "plus" => ResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan3.Plus,
                "academia" => ResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan3.Academia,
                _ => null,
            };
        }
    }
}