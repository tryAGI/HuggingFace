
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetQuicksearchReposFilterVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        GrantedAccess,
        /// <summary>
        /// 
        /// </summary>
        Own,
        /// <summary>
        /// 
        /// </summary>
        OwnOrgs,
        /// <summary>
        /// 
        /// </summary>
        SkipDisabled,
        /// <summary>
        /// 
        /// </summary>
        SkipGated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetQuicksearchReposFilterVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetQuicksearchReposFilterVariant1Item value)
        {
            return value switch
            {
                GetQuicksearchReposFilterVariant1Item.GrantedAccess => "granted_access",
                GetQuicksearchReposFilterVariant1Item.Own => "own",
                GetQuicksearchReposFilterVariant1Item.OwnOrgs => "own_orgs",
                GetQuicksearchReposFilterVariant1Item.SkipDisabled => "skip_disabled",
                GetQuicksearchReposFilterVariant1Item.SkipGated => "skip_gated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetQuicksearchReposFilterVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "granted_access" => GetQuicksearchReposFilterVariant1Item.GrantedAccess,
                "own" => GetQuicksearchReposFilterVariant1Item.Own,
                "own_orgs" => GetQuicksearchReposFilterVariant1Item.OwnOrgs,
                "skip_disabled" => GetQuicksearchReposFilterVariant1Item.SkipDisabled,
                "skip_gated" => GetQuicksearchReposFilterVariant1Item.SkipGated,
                _ => null,
            };
        }
    }
}