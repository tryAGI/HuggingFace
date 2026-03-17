
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1EventVariant8AuthorVariant1Plan
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
    public static class ResponseVariant1EventVariant8AuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1EventVariant8AuthorVariant1Plan value)
        {
            return value switch
            {
                ResponseVariant1EventVariant8AuthorVariant1Plan.Team => "team",
                ResponseVariant1EventVariant8AuthorVariant1Plan.Enterprise => "enterprise",
                ResponseVariant1EventVariant8AuthorVariant1Plan.Plus => "plus",
                ResponseVariant1EventVariant8AuthorVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1EventVariant8AuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseVariant1EventVariant8AuthorVariant1Plan.Team,
                "enterprise" => ResponseVariant1EventVariant8AuthorVariant1Plan.Enterprise,
                "plus" => ResponseVariant1EventVariant8AuthorVariant1Plan.Plus,
                "academia" => ResponseVariant1EventVariant8AuthorVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}