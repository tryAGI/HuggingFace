
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateQuicksearchRequestReposFilterVariant1Item
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
    public static class CreateQuicksearchRequestReposFilterVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQuicksearchRequestReposFilterVariant1Item value)
        {
            return value switch
            {
                CreateQuicksearchRequestReposFilterVariant1Item.GrantedAccess => "granted_access",
                CreateQuicksearchRequestReposFilterVariant1Item.Own => "own",
                CreateQuicksearchRequestReposFilterVariant1Item.OwnOrgs => "own_orgs",
                CreateQuicksearchRequestReposFilterVariant1Item.SkipDisabled => "skip_disabled",
                CreateQuicksearchRequestReposFilterVariant1Item.SkipGated => "skip_gated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQuicksearchRequestReposFilterVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "granted_access" => CreateQuicksearchRequestReposFilterVariant1Item.GrantedAccess,
                "own" => CreateQuicksearchRequestReposFilterVariant1Item.Own,
                "own_orgs" => CreateQuicksearchRequestReposFilterVariant1Item.OwnOrgs,
                "skip_disabled" => CreateQuicksearchRequestReposFilterVariant1Item.SkipDisabled,
                "skip_gated" => CreateQuicksearchRequestReposFilterVariant1Item.SkipGated,
                _ => null,
            };
        }
    }
}