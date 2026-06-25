
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgenticProvisioningServicesResponseDataItemAllowedUpdateDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        Down,
        /// <summary>
        /// 
        /// </summary>
        Up,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgenticProvisioningServicesResponseDataItemAllowedUpdateDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgenticProvisioningServicesResponseDataItemAllowedUpdateDirection value)
        {
            return value switch
            {
                GetAgenticProvisioningServicesResponseDataItemAllowedUpdateDirection.Any => "any",
                GetAgenticProvisioningServicesResponseDataItemAllowedUpdateDirection.Down => "down",
                GetAgenticProvisioningServicesResponseDataItemAllowedUpdateDirection.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgenticProvisioningServicesResponseDataItemAllowedUpdateDirection? ToEnum(string value)
        {
            return value switch
            {
                "any" => GetAgenticProvisioningServicesResponseDataItemAllowedUpdateDirection.Any,
                "down" => GetAgenticProvisioningServicesResponseDataItemAllowedUpdateDirection.Down,
                "up" => GetAgenticProvisioningServicesResponseDataItemAllowedUpdateDirection.Up,
                _ => null,
            };
        }
    }
}