
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgenticProvisioningServicesResponseDataItemScope
    {
        /// <summary>
        /// 
        /// </summary>
        Account,
        /// <summary>
        /// 
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgenticProvisioningServicesResponseDataItemScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgenticProvisioningServicesResponseDataItemScope value)
        {
            return value switch
            {
                GetAgenticProvisioningServicesResponseDataItemScope.Account => "account",
                GetAgenticProvisioningServicesResponseDataItemScope.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgenticProvisioningServicesResponseDataItemScope? ToEnum(string value)
        {
            return value switch
            {
                "account" => GetAgenticProvisioningServicesResponseDataItemScope.Account,
                "project" => GetAgenticProvisioningServicesResponseDataItemScope.Project,
                _ => null,
            };
        }
    }
}