
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsServiceAccountsResponseAccessTokenPermission
    {
        /// <summary>
        /// 
        /// </summary>
        CollectionRead,
        /// <summary>
        /// 
        /// </summary>
        CollectionWrite,
        /// <summary>
        /// 
        /// </summary>
        InferenceEndpointsInferWrite,
        /// <summary>
        /// 
        /// </summary>
        InferenceEndpointsWrite,
        /// <summary>
        /// 
        /// </summary>
        InferenceServerlessWrite,
        /// <summary>
        /// 
        /// </summary>
        JobWrite,
        /// <summary>
        /// 
        /// </summary>
        OrgRead,
        /// <summary>
        /// 
        /// </summary>
        OrgServiceAccountsRead,
        /// <summary>
        /// 
        /// </summary>
        OrgServiceAccountsWrite,
        /// <summary>
        /// 
        /// </summary>
        OrgWrite,
        /// <summary>
        /// 
        /// </summary>
        RepoContentRead,
        /// <summary>
        /// 
        /// </summary>
        RepoWrite,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsServiceAccountsResponseAccessTokenPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsServiceAccountsResponseAccessTokenPermission value)
        {
            return value switch
            {
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.CollectionRead => "collection.read",
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.CollectionWrite => "collection.write",
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.InferenceEndpointsInferWrite => "inference.endpoints.infer.write",
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.InferenceEndpointsWrite => "inference.endpoints.write",
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.InferenceServerlessWrite => "inference.serverless.write",
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.JobWrite => "job.write",
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.OrgRead => "org.read",
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.OrgServiceAccountsRead => "org.serviceAccounts.read",
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.OrgServiceAccountsWrite => "org.serviceAccounts.write",
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.OrgWrite => "org.write",
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.RepoContentRead => "repo.content.read",
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.RepoWrite => "repo.write",
                GetOrganizationsServiceAccountsResponseAccessTokenPermission.ResourceGroupWrite => "resourceGroup.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsServiceAccountsResponseAccessTokenPermission? ToEnum(string value)
        {
            return value switch
            {
                "collection.read" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.CollectionRead,
                "collection.write" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.CollectionWrite,
                "inference.endpoints.infer.write" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.InferenceEndpointsInferWrite,
                "inference.endpoints.write" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.InferenceEndpointsWrite,
                "inference.serverless.write" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.InferenceServerlessWrite,
                "job.write" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.JobWrite,
                "org.read" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.OrgRead,
                "org.serviceAccounts.read" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.OrgServiceAccountsRead,
                "org.serviceAccounts.write" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.OrgServiceAccountsWrite,
                "org.write" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.OrgWrite,
                "repo.content.read" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.RepoContentRead,
                "repo.write" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.RepoWrite,
                "resourceGroup.write" => GetOrganizationsServiceAccountsResponseAccessTokenPermission.ResourceGroupWrite,
                _ => null,
            };
        }
    }
}