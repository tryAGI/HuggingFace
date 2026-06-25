
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsUsersResponseRepoType
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
    public static class CreateOrganizationsResourceGroupsUsersResponseRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsUsersResponseRepoType value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsUsersResponseRepoType.Bucket => "bucket",
                CreateOrganizationsResourceGroupsUsersResponseRepoType.Dataset => "dataset",
                CreateOrganizationsResourceGroupsUsersResponseRepoType.Kernel => "kernel",
                CreateOrganizationsResourceGroupsUsersResponseRepoType.Model => "model",
                CreateOrganizationsResourceGroupsUsersResponseRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsUsersResponseRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateOrganizationsResourceGroupsUsersResponseRepoType.Bucket,
                "dataset" => CreateOrganizationsResourceGroupsUsersResponseRepoType.Dataset,
                "kernel" => CreateOrganizationsResourceGroupsUsersResponseRepoType.Kernel,
                "model" => CreateOrganizationsResourceGroupsUsersResponseRepoType.Model,
                "space" => CreateOrganizationsResourceGroupsUsersResponseRepoType.Space,
                _ => null,
            };
        }
    }
}