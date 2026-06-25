
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsResourceGroupsResponseRepoType
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
    public static class PatchOrganizationsResourceGroupsResponseRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsResponseRepoType value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsResponseRepoType.Bucket => "bucket",
                PatchOrganizationsResourceGroupsResponseRepoType.Dataset => "dataset",
                PatchOrganizationsResourceGroupsResponseRepoType.Kernel => "kernel",
                PatchOrganizationsResourceGroupsResponseRepoType.Model => "model",
                PatchOrganizationsResourceGroupsResponseRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsResponseRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchOrganizationsResourceGroupsResponseRepoType.Bucket,
                "dataset" => PatchOrganizationsResourceGroupsResponseRepoType.Dataset,
                "kernel" => PatchOrganizationsResourceGroupsResponseRepoType.Kernel,
                "model" => PatchOrganizationsResourceGroupsResponseRepoType.Model,
                "space" => PatchOrganizationsResourceGroupsResponseRepoType.Space,
                _ => null,
            };
        }
    }
}