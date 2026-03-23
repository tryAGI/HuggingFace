
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseItemRepoType
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
    public static class GetOrganizationsResourceGroupsResponseItemRepoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseItemRepoType value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseItemRepoType.Bucket => "bucket",
                GetOrganizationsResourceGroupsResponseItemRepoType.Dataset => "dataset",
                GetOrganizationsResourceGroupsResponseItemRepoType.Kernel => "kernel",
                GetOrganizationsResourceGroupsResponseItemRepoType.Model => "model",
                GetOrganizationsResourceGroupsResponseItemRepoType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseItemRepoType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetOrganizationsResourceGroupsResponseItemRepoType.Bucket,
                "dataset" => GetOrganizationsResourceGroupsResponseItemRepoType.Dataset,
                "kernel" => GetOrganizationsResourceGroupsResponseItemRepoType.Kernel,
                "model" => GetOrganizationsResourceGroupsResponseItemRepoType.Model,
                "space" => GetOrganizationsResourceGroupsResponseItemRepoType.Space,
                _ => null,
            };
        }
    }
}