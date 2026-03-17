
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewStatusAuthorVariant1Plan
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
    public static class ResponseNewStatusAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewStatusAuthorVariant1Plan value)
        {
            return value switch
            {
                ResponseNewStatusAuthorVariant1Plan.Team => "team",
                ResponseNewStatusAuthorVariant1Plan.Enterprise => "enterprise",
                ResponseNewStatusAuthorVariant1Plan.Plus => "plus",
                ResponseNewStatusAuthorVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewStatusAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewStatusAuthorVariant1Plan.Team,
                "enterprise" => ResponseNewStatusAuthorVariant1Plan.Enterprise,
                "plus" => ResponseNewStatusAuthorVariant1Plan.Plus,
                "academia" => ResponseNewStatusAuthorVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}