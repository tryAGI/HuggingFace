
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgenticProvisioningServicesResponseDataItemKind
    {
        /// <summary>
        /// 
        /// </summary>
        Deployable,
        /// <summary>
        /// 
        /// </summary>
        Plan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgenticProvisioningServicesResponseDataItemKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgenticProvisioningServicesResponseDataItemKind value)
        {
            return value switch
            {
                GetAgenticProvisioningServicesResponseDataItemKind.Deployable => "deployable",
                GetAgenticProvisioningServicesResponseDataItemKind.Plan => "plan",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgenticProvisioningServicesResponseDataItemKind? ToEnum(string value)
        {
            return value switch
            {
                "deployable" => GetAgenticProvisioningServicesResponseDataItemKind.Deployable,
                "plan" => GetAgenticProvisioningServicesResponseDataItemKind.Plan,
                _ => null,
            };
        }
    }
}