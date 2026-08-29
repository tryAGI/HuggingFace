
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUsersFollowingOrgsResponseItemOrgType
    {
        /// <summary>
        ///
        /// </summary>
        Classroom,
        /// <summary>
        ///
        /// </summary>
        Community,
        /// <summary>
        ///
        /// </summary>
        Company,
        /// <summary>
        ///
        /// </summary>
        Government,
        /// <summary>
        ///
        /// </summary>
        NonProfit,
        /// <summary>
        ///
        /// </summary>
        University,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsersFollowingOrgsResponseItemOrgTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsersFollowingOrgsResponseItemOrgType value)
        {
            return value switch
            {
                GetUsersFollowingOrgsResponseItemOrgType.Classroom => "classroom",
                GetUsersFollowingOrgsResponseItemOrgType.Community => "community",
                GetUsersFollowingOrgsResponseItemOrgType.Company => "company",
                GetUsersFollowingOrgsResponseItemOrgType.Government => "government",
                GetUsersFollowingOrgsResponseItemOrgType.NonProfit => "non-profit",
                GetUsersFollowingOrgsResponseItemOrgType.University => "university",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsersFollowingOrgsResponseItemOrgType? ToEnum(string value)
        {
            return value switch
            {
                "classroom" => GetUsersFollowingOrgsResponseItemOrgType.Classroom,
                "community" => GetUsersFollowingOrgsResponseItemOrgType.Community,
                "company" => GetUsersFollowingOrgsResponseItemOrgType.Company,
                "government" => GetUsersFollowingOrgsResponseItemOrgType.Government,
                "non-profit" => GetUsersFollowingOrgsResponseItemOrgType.NonProfit,
                "university" => GetUsersFollowingOrgsResponseItemOrgType.University,
                _ => null,
            };
        }
    }
}