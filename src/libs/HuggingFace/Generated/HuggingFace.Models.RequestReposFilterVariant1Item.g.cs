
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestReposFilterVariant1Item
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
    public static class RequestReposFilterVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestReposFilterVariant1Item value)
        {
            return value switch
            {
                RequestReposFilterVariant1Item.SkipDisabled => "skip_disabled",
                RequestReposFilterVariant1Item.SkipGated => "skip_gated",
                RequestReposFilterVariant1Item.Own => "own",
                RequestReposFilterVariant1Item.OwnOrgs => "own_orgs",
                RequestReposFilterVariant1Item.GrantedAccess => "granted_access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestReposFilterVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "skip_disabled" => RequestReposFilterVariant1Item.SkipDisabled,
                "skip_gated" => RequestReposFilterVariant1Item.SkipGated,
                "own" => RequestReposFilterVariant1Item.Own,
                "own_orgs" => RequestReposFilterVariant1Item.OwnOrgs,
                "granted_access" => RequestReposFilterVariant1Item.GrantedAccess,
                _ => null,
            };
        }
    }
}