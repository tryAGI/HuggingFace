
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsServiceAccountsTokensRequestPermission
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
    public static class CreateOrganizationsServiceAccountsTokensRequestPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsServiceAccountsTokensRequestPermission value)
        {
            return value switch
            {
                CreateOrganizationsServiceAccountsTokensRequestPermission.CollectionRead => "collection.read",
                CreateOrganizationsServiceAccountsTokensRequestPermission.CollectionWrite => "collection.write",
                CreateOrganizationsServiceAccountsTokensRequestPermission.InferenceEndpointsInferWrite => "inference.endpoints.infer.write",
                CreateOrganizationsServiceAccountsTokensRequestPermission.InferenceEndpointsWrite => "inference.endpoints.write",
                CreateOrganizationsServiceAccountsTokensRequestPermission.InferenceServerlessWrite => "inference.serverless.write",
                CreateOrganizationsServiceAccountsTokensRequestPermission.JobWrite => "job.write",
                CreateOrganizationsServiceAccountsTokensRequestPermission.OrgRead => "org.read",
                CreateOrganizationsServiceAccountsTokensRequestPermission.OrgServiceAccountsRead => "org.serviceAccounts.read",
                CreateOrganizationsServiceAccountsTokensRequestPermission.OrgServiceAccountsWrite => "org.serviceAccounts.write",
                CreateOrganizationsServiceAccountsTokensRequestPermission.OrgWrite => "org.write",
                CreateOrganizationsServiceAccountsTokensRequestPermission.RepoContentRead => "repo.content.read",
                CreateOrganizationsServiceAccountsTokensRequestPermission.RepoWrite => "repo.write",
                CreateOrganizationsServiceAccountsTokensRequestPermission.ResourceGroupWrite => "resourceGroup.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsServiceAccountsTokensRequestPermission? ToEnum(string value)
        {
            return value switch
            {
                "collection.read" => CreateOrganizationsServiceAccountsTokensRequestPermission.CollectionRead,
                "collection.write" => CreateOrganizationsServiceAccountsTokensRequestPermission.CollectionWrite,
                "inference.endpoints.infer.write" => CreateOrganizationsServiceAccountsTokensRequestPermission.InferenceEndpointsInferWrite,
                "inference.endpoints.write" => CreateOrganizationsServiceAccountsTokensRequestPermission.InferenceEndpointsWrite,
                "inference.serverless.write" => CreateOrganizationsServiceAccountsTokensRequestPermission.InferenceServerlessWrite,
                "job.write" => CreateOrganizationsServiceAccountsTokensRequestPermission.JobWrite,
                "org.read" => CreateOrganizationsServiceAccountsTokensRequestPermission.OrgRead,
                "org.serviceAccounts.read" => CreateOrganizationsServiceAccountsTokensRequestPermission.OrgServiceAccountsRead,
                "org.serviceAccounts.write" => CreateOrganizationsServiceAccountsTokensRequestPermission.OrgServiceAccountsWrite,
                "org.write" => CreateOrganizationsServiceAccountsTokensRequestPermission.OrgWrite,
                "repo.content.read" => CreateOrganizationsServiceAccountsTokensRequestPermission.RepoContentRead,
                "repo.write" => CreateOrganizationsServiceAccountsTokensRequestPermission.RepoWrite,
                "resourceGroup.write" => CreateOrganizationsServiceAccountsTokensRequestPermission.ResourceGroupWrite,
                _ => null,
            };
        }
    }
}