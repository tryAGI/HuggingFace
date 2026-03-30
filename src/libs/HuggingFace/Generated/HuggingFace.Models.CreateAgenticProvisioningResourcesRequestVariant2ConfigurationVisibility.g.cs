
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: private
    /// </summary>
    public enum CreateAgenticProvisioningResourcesRequestVariant2ConfigurationVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgenticProvisioningResourcesRequestVariant2ConfigurationVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgenticProvisioningResourcesRequestVariant2ConfigurationVisibility value)
        {
            return value switch
            {
                CreateAgenticProvisioningResourcesRequestVariant2ConfigurationVisibility.Private => "private",
                CreateAgenticProvisioningResourcesRequestVariant2ConfigurationVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgenticProvisioningResourcesRequestVariant2ConfigurationVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateAgenticProvisioningResourcesRequestVariant2ConfigurationVisibility.Private,
                "public" => CreateAgenticProvisioningResourcesRequestVariant2ConfigurationVisibility.Public,
                _ => null,
            };
        }
    }
}