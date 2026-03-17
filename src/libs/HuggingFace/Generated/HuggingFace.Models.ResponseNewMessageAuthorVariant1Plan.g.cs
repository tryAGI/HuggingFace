
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageAuthorVariant1Plan
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
    public static class ResponseNewMessageAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageAuthorVariant1Plan value)
        {
            return value switch
            {
                ResponseNewMessageAuthorVariant1Plan.Team => "team",
                ResponseNewMessageAuthorVariant1Plan.Enterprise => "enterprise",
                ResponseNewMessageAuthorVariant1Plan.Plus => "plus",
                ResponseNewMessageAuthorVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageAuthorVariant1Plan.Team,
                "enterprise" => ResponseNewMessageAuthorVariant1Plan.Enterprise,
                "plus" => ResponseNewMessageAuthorVariant1Plan.Plus,
                "academia" => ResponseNewMessageAuthorVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}