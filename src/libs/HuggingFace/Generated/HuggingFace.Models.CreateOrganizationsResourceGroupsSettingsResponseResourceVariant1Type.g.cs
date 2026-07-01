
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bucket,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Kernel,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type.Bucket => "bucket",
                CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type.Dataset => "dataset",
                CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type.Kernel => "kernel",
                CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type.Model => "model",
                CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type.Bucket,
                "dataset" => CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type.Dataset,
                "kernel" => CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type.Kernel,
                "model" => CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type.Model,
                "space" => CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type.Space,
                _ => null,
            };
        }
    }
}