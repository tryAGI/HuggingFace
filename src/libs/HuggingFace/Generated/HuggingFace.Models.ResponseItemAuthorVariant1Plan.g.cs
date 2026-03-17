
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemAuthorVariant1Plan
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
    public static class ResponseItemAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemAuthorVariant1Plan value)
        {
            return value switch
            {
                ResponseItemAuthorVariant1Plan.Team => "team",
                ResponseItemAuthorVariant1Plan.Enterprise => "enterprise",
                ResponseItemAuthorVariant1Plan.Plus => "plus",
                ResponseItemAuthorVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemAuthorVariant1Plan.Team,
                "enterprise" => ResponseItemAuthorVariant1Plan.Enterprise,
                "plus" => ResponseItemAuthorVariant1Plan.Plus,
                "academia" => ResponseItemAuthorVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}