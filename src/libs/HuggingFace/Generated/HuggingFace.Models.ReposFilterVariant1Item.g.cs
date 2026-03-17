
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReposFilterVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        SkipDisabled,
        /// <summary>
        /// 
        /// </summary>
        SkipGated,
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
        GrantedAccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposFilterVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposFilterVariant1Item value)
        {
            return value switch
            {
                ReposFilterVariant1Item.SkipDisabled => "skip_disabled",
                ReposFilterVariant1Item.SkipGated => "skip_gated",
                ReposFilterVariant1Item.Own => "own",
                ReposFilterVariant1Item.OwnOrgs => "own_orgs",
                ReposFilterVariant1Item.GrantedAccess => "granted_access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposFilterVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "skip_disabled" => ReposFilterVariant1Item.SkipDisabled,
                "skip_gated" => ReposFilterVariant1Item.SkipGated,
                "own" => ReposFilterVariant1Item.Own,
                "own_orgs" => ReposFilterVariant1Item.OwnOrgs,
                "granted_access" => ReposFilterVariant1Item.GrantedAccess,
                _ => null,
            };
        }
    }
}