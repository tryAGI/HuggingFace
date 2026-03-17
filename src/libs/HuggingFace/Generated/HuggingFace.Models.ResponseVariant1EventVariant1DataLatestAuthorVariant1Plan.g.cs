
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1EventVariant1DataLatestAuthorVariant1Plan
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
    public static class ResponseVariant1EventVariant1DataLatestAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1EventVariant1DataLatestAuthorVariant1Plan value)
        {
            return value switch
            {
                ResponseVariant1EventVariant1DataLatestAuthorVariant1Plan.Team => "team",
                ResponseVariant1EventVariant1DataLatestAuthorVariant1Plan.Enterprise => "enterprise",
                ResponseVariant1EventVariant1DataLatestAuthorVariant1Plan.Plus => "plus",
                ResponseVariant1EventVariant1DataLatestAuthorVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1EventVariant1DataLatestAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseVariant1EventVariant1DataLatestAuthorVariant1Plan.Team,
                "enterprise" => ResponseVariant1EventVariant1DataLatestAuthorVariant1Plan.Enterprise,
                "plus" => ResponseVariant1EventVariant1DataLatestAuthorVariant1Plan.Plus,
                "academia" => ResponseVariant1EventVariant1DataLatestAuthorVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}