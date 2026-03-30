
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgenticProvisioningServicesResponseDataItemCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
        /// <summary>
        /// 
        /// </summary>
        Analytics,
        /// <summary>
        /// 
        /// </summary>
        Auth,
        /// <summary>
        /// 
        /// </summary>
        Cache,
        /// <summary>
        /// 
        /// </summary>
        Cdn,
        /// <summary>
        /// 
        /// </summary>
        Ci,
        /// <summary>
        /// 
        /// </summary>
        Compute,
        /// <summary>
        /// 
        /// </summary>
        Database,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        FeatureFlags,
        /// <summary>
        /// 
        /// </summary>
        Messaging,
        /// <summary>
        /// 
        /// </summary>
        Notification,
        /// <summary>
        /// 
        /// </summary>
        Observability,
        /// <summary>
        /// 
        /// </summary>
        Payments,
        /// <summary>
        /// 
        /// </summary>
        Search,
        /// <summary>
        /// 
        /// </summary>
        Storage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgenticProvisioningServicesResponseDataItemCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgenticProvisioningServicesResponseDataItemCategorie value)
        {
            return value switch
            {
                GetAgenticProvisioningServicesResponseDataItemCategorie.Ai => "ai",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Analytics => "analytics",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Auth => "auth",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Cache => "cache",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Cdn => "cdn",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Ci => "ci",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Compute => "compute",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Database => "database",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Email => "email",
                GetAgenticProvisioningServicesResponseDataItemCategorie.FeatureFlags => "feature_flags",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Messaging => "messaging",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Notification => "notification",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Observability => "observability",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Payments => "payments",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Search => "search",
                GetAgenticProvisioningServicesResponseDataItemCategorie.Storage => "storage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgenticProvisioningServicesResponseDataItemCategorie? ToEnum(string value)
        {
            return value switch
            {
                "ai" => GetAgenticProvisioningServicesResponseDataItemCategorie.Ai,
                "analytics" => GetAgenticProvisioningServicesResponseDataItemCategorie.Analytics,
                "auth" => GetAgenticProvisioningServicesResponseDataItemCategorie.Auth,
                "cache" => GetAgenticProvisioningServicesResponseDataItemCategorie.Cache,
                "cdn" => GetAgenticProvisioningServicesResponseDataItemCategorie.Cdn,
                "ci" => GetAgenticProvisioningServicesResponseDataItemCategorie.Ci,
                "compute" => GetAgenticProvisioningServicesResponseDataItemCategorie.Compute,
                "database" => GetAgenticProvisioningServicesResponseDataItemCategorie.Database,
                "email" => GetAgenticProvisioningServicesResponseDataItemCategorie.Email,
                "feature_flags" => GetAgenticProvisioningServicesResponseDataItemCategorie.FeatureFlags,
                "messaging" => GetAgenticProvisioningServicesResponseDataItemCategorie.Messaging,
                "notification" => GetAgenticProvisioningServicesResponseDataItemCategorie.Notification,
                "observability" => GetAgenticProvisioningServicesResponseDataItemCategorie.Observability,
                "payments" => GetAgenticProvisioningServicesResponseDataItemCategorie.Payments,
                "search" => GetAgenticProvisioningServicesResponseDataItemCategorie.Search,
                "storage" => GetAgenticProvisioningServicesResponseDataItemCategorie.Storage,
                _ => null,
            };
        }
    }
}