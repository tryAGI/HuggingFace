
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsResponseRepoType
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
    public static class CreateOrganizationsResourceGroupsResponseRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsResponseRepoType value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsResponseRepoType.Bucket => "bucket",
                CreateOrganizationsResourceGroupsResponseRepoType.Dataset => "dataset",
                CreateOrganizationsResourceGroupsResponseRepoType.Kernel => "kernel",
                CreateOrganizationsResourceGroupsResponseRepoType.Model => "model",
                CreateOrganizationsResourceGroupsResponseRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsResponseRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateOrganizationsResourceGroupsResponseRepoType.Bucket,
                "dataset" => CreateOrganizationsResourceGroupsResponseRepoType.Dataset,
                "kernel" => CreateOrganizationsResourceGroupsResponseRepoType.Kernel,
                "model" => CreateOrganizationsResourceGroupsResponseRepoType.Model,
                "space" => CreateOrganizationsResourceGroupsResponseRepoType.Space,
                _ => null,
            };
        }
    }
}