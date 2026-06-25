
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteOrganizationsResourceGroupsUsersResponseRepoType
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
    public static class DeleteOrganizationsResourceGroupsUsersResponseRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteOrganizationsResourceGroupsUsersResponseRepoType value)
        {
            return value switch
            {
                DeleteOrganizationsResourceGroupsUsersResponseRepoType.Bucket => "bucket",
                DeleteOrganizationsResourceGroupsUsersResponseRepoType.Dataset => "dataset",
                DeleteOrganizationsResourceGroupsUsersResponseRepoType.Kernel => "kernel",
                DeleteOrganizationsResourceGroupsUsersResponseRepoType.Model => "model",
                DeleteOrganizationsResourceGroupsUsersResponseRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteOrganizationsResourceGroupsUsersResponseRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => DeleteOrganizationsResourceGroupsUsersResponseRepoType.Bucket,
                "dataset" => DeleteOrganizationsResourceGroupsUsersResponseRepoType.Dataset,
                "kernel" => DeleteOrganizationsResourceGroupsUsersResponseRepoType.Kernel,
                "model" => DeleteOrganizationsResourceGroupsUsersResponseRepoType.Model,
                "space" => DeleteOrganizationsResourceGroupsUsersResponseRepoType.Space,
                _ => null,
            };
        }
    }
}