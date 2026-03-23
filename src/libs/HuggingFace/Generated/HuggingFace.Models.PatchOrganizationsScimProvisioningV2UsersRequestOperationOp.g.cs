
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// `remove` operation is not supported for non-managed organizations
    /// </summary>
    public enum PatchOrganizationsScimProvisioningV2UsersRequestOperationOp
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Remove,
        /// <summary>
        /// 
        /// </summary>
        Replace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchOrganizationsScimProvisioningV2UsersRequestOperationOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsScimProvisioningV2UsersRequestOperationOp value)
        {
            return value switch
            {
                PatchOrganizationsScimProvisioningV2UsersRequestOperationOp.Add => "add",
                PatchOrganizationsScimProvisioningV2UsersRequestOperationOp.Remove => "remove",
                PatchOrganizationsScimProvisioningV2UsersRequestOperationOp.Replace => "replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsScimProvisioningV2UsersRequestOperationOp? ToEnum(string value)
        {
            return value switch
            {
                "add" => PatchOrganizationsScimProvisioningV2UsersRequestOperationOp.Add,
                "remove" => PatchOrganizationsScimProvisioningV2UsersRequestOperationOp.Remove,
                "replace" => PatchOrganizationsScimProvisioningV2UsersRequestOperationOp.Replace,
                _ => null,
            };
        }
    }
}