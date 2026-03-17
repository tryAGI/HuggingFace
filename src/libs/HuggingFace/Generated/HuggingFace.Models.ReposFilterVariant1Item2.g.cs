
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReposFilterVariant1Item2
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
    public static class ReposFilterVariant1Item2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposFilterVariant1Item2 value)
        {
            return value switch
            {
                ReposFilterVariant1Item2.SkipDisabled => "skip_disabled",
                ReposFilterVariant1Item2.SkipGated => "skip_gated",
                ReposFilterVariant1Item2.Own => "own",
                ReposFilterVariant1Item2.OwnOrgs => "own_orgs",
                ReposFilterVariant1Item2.GrantedAccess => "granted_access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposFilterVariant1Item2? ToEnum(string value)
        {
            return value switch
            {
                "skip_disabled" => ReposFilterVariant1Item2.SkipDisabled,
                "skip_gated" => ReposFilterVariant1Item2.SkipGated,
                "own" => ReposFilterVariant1Item2.Own,
                "own_orgs" => ReposFilterVariant1Item2.OwnOrgs,
                "granted_access" => ReposFilterVariant1Item2.GrantedAccess,
                _ => null,
            };
        }
    }
}