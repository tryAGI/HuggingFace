
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3AuthorDataVariant1Plan
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
    public static class ResponseDataItemVariant3AuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3AuthorDataVariant1Plan value)
        {
            return value switch
            {
                ResponseDataItemVariant3AuthorDataVariant1Plan.Team => "team",
                ResponseDataItemVariant3AuthorDataVariant1Plan.Enterprise => "enterprise",
                ResponseDataItemVariant3AuthorDataVariant1Plan.Plus => "plus",
                ResponseDataItemVariant3AuthorDataVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3AuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataItemVariant3AuthorDataVariant1Plan.Team,
                "enterprise" => ResponseDataItemVariant3AuthorDataVariant1Plan.Enterprise,
                "plus" => ResponseDataItemVariant3AuthorDataVariant1Plan.Plus,
                "academia" => ResponseDataItemVariant3AuthorDataVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}