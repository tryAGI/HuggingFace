
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsServiceAccountsTokensRequestPermission
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
    public static class PatchOrganizationsServiceAccountsTokensRequestPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsServiceAccountsTokensRequestPermission value)
        {
            return value switch
            {
                PatchOrganizationsServiceAccountsTokensRequestPermission.CollectionRead => "collection.read",
                PatchOrganizationsServiceAccountsTokensRequestPermission.CollectionWrite => "collection.write",
                PatchOrganizationsServiceAccountsTokensRequestPermission.InferenceEndpointsInferWrite => "inference.endpoints.infer.write",
                PatchOrganizationsServiceAccountsTokensRequestPermission.InferenceEndpointsWrite => "inference.endpoints.write",
                PatchOrganizationsServiceAccountsTokensRequestPermission.InferenceServerlessWrite => "inference.serverless.write",
                PatchOrganizationsServiceAccountsTokensRequestPermission.JobWrite => "job.write",
                PatchOrganizationsServiceAccountsTokensRequestPermission.OrgRead => "org.read",
                PatchOrganizationsServiceAccountsTokensRequestPermission.OrgWrite => "org.write",
                PatchOrganizationsServiceAccountsTokensRequestPermission.RepoContentRead => "repo.content.read",
                PatchOrganizationsServiceAccountsTokensRequestPermission.RepoWrite => "repo.write",
                PatchOrganizationsServiceAccountsTokensRequestPermission.ResourceGroupWrite => "resourceGroup.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsServiceAccountsTokensRequestPermission? ToEnum(string value)
        {
            return value switch
            {
                "collection.read" => PatchOrganizationsServiceAccountsTokensRequestPermission.CollectionRead,
                "collection.write" => PatchOrganizationsServiceAccountsTokensRequestPermission.CollectionWrite,
                "inference.endpoints.infer.write" => PatchOrganizationsServiceAccountsTokensRequestPermission.InferenceEndpointsInferWrite,
                "inference.endpoints.write" => PatchOrganizationsServiceAccountsTokensRequestPermission.InferenceEndpointsWrite,
                "inference.serverless.write" => PatchOrganizationsServiceAccountsTokensRequestPermission.InferenceServerlessWrite,
                "job.write" => PatchOrganizationsServiceAccountsTokensRequestPermission.JobWrite,
                "org.read" => PatchOrganizationsServiceAccountsTokensRequestPermission.OrgRead,
                "org.write" => PatchOrganizationsServiceAccountsTokensRequestPermission.OrgWrite,
                "repo.content.read" => PatchOrganizationsServiceAccountsTokensRequestPermission.RepoContentRead,
                "repo.write" => PatchOrganizationsServiceAccountsTokensRequestPermission.RepoWrite,
                "resourceGroup.write" => PatchOrganizationsServiceAccountsTokensRequestPermission.ResourceGroupWrite,
                _ => null,
            };
        }
    }
}