
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsSettingsResponseRepoType
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
    public static class CreateOrganizationsResourceGroupsSettingsResponseRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsSettingsResponseRepoType value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsSettingsResponseRepoType.Bucket => "bucket",
                CreateOrganizationsResourceGroupsSettingsResponseRepoType.Dataset => "dataset",
                CreateOrganizationsResourceGroupsSettingsResponseRepoType.Kernel => "kernel",
                CreateOrganizationsResourceGroupsSettingsResponseRepoType.Model => "model",
                CreateOrganizationsResourceGroupsSettingsResponseRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsResponseRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateOrganizationsResourceGroupsSettingsResponseRepoType.Bucket,
                "dataset" => CreateOrganizationsResourceGroupsSettingsResponseRepoType.Dataset,
                "kernel" => CreateOrganizationsResourceGroupsSettingsResponseRepoType.Kernel,
                "model" => CreateOrganizationsResourceGroupsSettingsResponseRepoType.Model,
                "space" => CreateOrganizationsResourceGroupsSettingsResponseRepoType.Space,
                _ => null,
            };
        }
    }
}