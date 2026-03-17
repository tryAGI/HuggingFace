
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2
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
    public static class ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2.Team => "team",
                ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2.Plus => "plus",
                ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2.Team,
                "enterprise" => ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2.Plus,
                "academia" => ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2.Academia,
                _ => null,
            };
        }
    }
}