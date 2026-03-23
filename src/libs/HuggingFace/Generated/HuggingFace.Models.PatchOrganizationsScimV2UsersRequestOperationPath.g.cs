
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsScimV2UsersRequestOperationPath
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
    public static class PatchOrganizationsScimV2UsersRequestOperationPathExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsScimV2UsersRequestOperationPath value)
        {
            return value switch
            {
                PatchOrganizationsScimV2UsersRequestOperationPath.Active => "active",
                PatchOrganizationsScimV2UsersRequestOperationPath.EmailstypeEqworkValue => "emails[type eq 'work'].value",
                PatchOrganizationsScimV2UsersRequestOperationPath.ExternalId => "externalId",
                PatchOrganizationsScimV2UsersRequestOperationPath.NameFamilyName => "name.familyName",
                PatchOrganizationsScimV2UsersRequestOperationPath.NameGivenName => "name.givenName",
                PatchOrganizationsScimV2UsersRequestOperationPath.UserName => "userName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsScimV2UsersRequestOperationPath? ToEnum(string value)
        {
            return value switch
            {
                "active" => PatchOrganizationsScimV2UsersRequestOperationPath.Active,
                "emails[type eq 'work'].value" => PatchOrganizationsScimV2UsersRequestOperationPath.EmailstypeEqworkValue,
                "externalId" => PatchOrganizationsScimV2UsersRequestOperationPath.ExternalId,
                "name.familyName" => PatchOrganizationsScimV2UsersRequestOperationPath.NameFamilyName,
                "name.givenName" => PatchOrganizationsScimV2UsersRequestOperationPath.NameGivenName,
                "userName" => PatchOrganizationsScimV2UsersRequestOperationPath.UserName,
                _ => null,
            };
        }
    }
}