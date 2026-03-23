
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsScimProvisioningV2UsersRequestOperationPath
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        EmailstypeEqworkValue,
        /// <summary>
        /// 
        /// </summary>
        ExternalId,
        /// <summary>
        /// 
        /// </summary>
        NameFamilyName,
        /// <summary>
        /// 
        /// </summary>
        NameGivenName,
        /// <summary>
        /// 
        /// </summary>
        UserName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchOrganizationsScimProvisioningV2UsersRequestOperationPathExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsScimProvisioningV2UsersRequestOperationPath value)
        {
            return value switch
            {
                PatchOrganizationsScimProvisioningV2UsersRequestOperationPath.Active => "active",
                PatchOrganizationsScimProvisioningV2UsersRequestOperationPath.EmailstypeEqworkValue => "emails[type eq 'work'].value",
                PatchOrganizationsScimProvisioningV2UsersRequestOperationPath.ExternalId => "externalId",
                PatchOrganizationsScimProvisioningV2UsersRequestOperationPath.NameFamilyName => "name.familyName",
                PatchOrganizationsScimProvisioningV2UsersRequestOperationPath.NameGivenName => "name.givenName",
                PatchOrganizationsScimProvisioningV2UsersRequestOperationPath.UserName => "userName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsScimProvisioningV2UsersRequestOperationPath? ToEnum(string value)
        {
            return value switch
            {
                "active" => PatchOrganizationsScimProvisioningV2UsersRequestOperationPath.Active,
                "emails[type eq 'work'].value" => PatchOrganizationsScimProvisioningV2UsersRequestOperationPath.EmailstypeEqworkValue,
                "externalId" => PatchOrganizationsScimProvisioningV2UsersRequestOperationPath.ExternalId,
                "name.familyName" => PatchOrganizationsScimProvisioningV2UsersRequestOperationPath.NameFamilyName,
                "name.givenName" => PatchOrganizationsScimProvisioningV2UsersRequestOperationPath.NameGivenName,
                "userName" => PatchOrganizationsScimProvisioningV2UsersRequestOperationPath.UserName,
                _ => null,
            };
        }
    }
}