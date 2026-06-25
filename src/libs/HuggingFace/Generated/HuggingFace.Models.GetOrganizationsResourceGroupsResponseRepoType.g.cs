
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseRepoType
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
    public static class GetOrganizationsResourceGroupsResponseRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseRepoType value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseRepoType.Bucket => "bucket",
                GetOrganizationsResourceGroupsResponseRepoType.Dataset => "dataset",
                GetOrganizationsResourceGroupsResponseRepoType.Kernel => "kernel",
                GetOrganizationsResourceGroupsResponseRepoType.Model => "model",
                GetOrganizationsResourceGroupsResponseRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetOrganizationsResourceGroupsResponseRepoType.Bucket,
                "dataset" => GetOrganizationsResourceGroupsResponseRepoType.Dataset,
                "kernel" => GetOrganizationsResourceGroupsResponseRepoType.Kernel,
                "model" => GetOrganizationsResourceGroupsResponseRepoType.Model,
                "space" => GetOrganizationsResourceGroupsResponseRepoType.Space,
                _ => null,
            };
        }
    }
}