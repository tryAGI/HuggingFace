
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsResourceGroupsUsersResponseRepoType
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
    public static class PatchOrganizationsResourceGroupsUsersResponseRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsUsersResponseRepoType value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsUsersResponseRepoType.Bucket => "bucket",
                PatchOrganizationsResourceGroupsUsersResponseRepoType.Dataset => "dataset",
                PatchOrganizationsResourceGroupsUsersResponseRepoType.Kernel => "kernel",
                PatchOrganizationsResourceGroupsUsersResponseRepoType.Model => "model",
                PatchOrganizationsResourceGroupsUsersResponseRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsUsersResponseRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchOrganizationsResourceGroupsUsersResponseRepoType.Bucket,
                "dataset" => PatchOrganizationsResourceGroupsUsersResponseRepoType.Dataset,
                "kernel" => PatchOrganizationsResourceGroupsUsersResponseRepoType.Kernel,
                "model" => PatchOrganizationsResourceGroupsUsersResponseRepoType.Model,
                "space" => PatchOrganizationsResourceGroupsUsersResponseRepoType.Space,
                _ => null,
            };
        }
    }
}