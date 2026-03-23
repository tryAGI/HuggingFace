
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQuicksearchReposFilterVariant1Item
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
    public static class CreateQuicksearchReposFilterVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchReposFilterVariant1Item value)
        {
            return value switch
            {
                CreateQuicksearchReposFilterVariant1Item.GrantedAccess => "granted_access",
                CreateQuicksearchReposFilterVariant1Item.Own => "own",
                CreateQuicksearchReposFilterVariant1Item.OwnOrgs => "own_orgs",
                CreateQuicksearchReposFilterVariant1Item.SkipDisabled => "skip_disabled",
                CreateQuicksearchReposFilterVariant1Item.SkipGated => "skip_gated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchReposFilterVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "granted_access" => CreateQuicksearchReposFilterVariant1Item.GrantedAccess,
                "own" => CreateQuicksearchReposFilterVariant1Item.Own,
                "own_orgs" => CreateQuicksearchReposFilterVariant1Item.OwnOrgs,
                "skip_disabled" => CreateQuicksearchReposFilterVariant1Item.SkipDisabled,
                "skip_gated" => CreateQuicksearchReposFilterVariant1Item.SkipGated,
                _ => null,
            };
        }
    }
}