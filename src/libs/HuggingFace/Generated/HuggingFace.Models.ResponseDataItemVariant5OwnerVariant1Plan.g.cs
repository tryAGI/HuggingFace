
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant5OwnerVariant1Plan
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
    public static class ResponseDataItemVariant5OwnerVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant5OwnerVariant1Plan value)
        {
            return value switch
            {
                ResponseDataItemVariant5OwnerVariant1Plan.Team => "team",
                ResponseDataItemVariant5OwnerVariant1Plan.Enterprise => "enterprise",
                ResponseDataItemVariant5OwnerVariant1Plan.Plus => "plus",
                ResponseDataItemVariant5OwnerVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant5OwnerVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataItemVariant5OwnerVariant1Plan.Team,
                "enterprise" => ResponseDataItemVariant5OwnerVariant1Plan.Enterprise,
                "plus" => ResponseDataItemVariant5OwnerVariant1Plan.Plus,
                "academia" => ResponseDataItemVariant5OwnerVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}