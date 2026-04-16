
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWhoamiV2ResponseOrgResourceGroupRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        NoAccess,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWhoamiV2ResponseOrgResourceGroupRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWhoamiV2ResponseOrgResourceGroupRole value)
        {
            return value switch
            {
                GetWhoamiV2ResponseOrgResourceGroupRole.Admin => "admin",
                GetWhoamiV2ResponseOrgResourceGroupRole.Contributor => "contributor",
                GetWhoamiV2ResponseOrgResourceGroupRole.NoAccess => "no_access",
                GetWhoamiV2ResponseOrgResourceGroupRole.Read => "read",
                GetWhoamiV2ResponseOrgResourceGroupRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWhoamiV2ResponseOrgResourceGroupRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetWhoamiV2ResponseOrgResourceGroupRole.Admin,
                "contributor" => GetWhoamiV2ResponseOrgResourceGroupRole.Contributor,
                "no_access" => GetWhoamiV2ResponseOrgResourceGroupRole.NoAccess,
                "read" => GetWhoamiV2ResponseOrgResourceGroupRole.Read,
                "write" => GetWhoamiV2ResponseOrgResourceGroupRole.Write,
                _ => null,
            };
        }
    }
}