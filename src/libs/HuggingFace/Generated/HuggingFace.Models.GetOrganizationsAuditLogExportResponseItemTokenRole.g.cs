
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsAuditLogExportResponseItemTokenRole
    {
        /// <summary>
        /// 
        /// </summary>
        FineGrained,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsAuditLogExportResponseItemTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsAuditLogExportResponseItemTokenRole value)
        {
            return value switch
            {
                GetOrganizationsAuditLogExportResponseItemTokenRole.FineGrained => "fineGrained",
                GetOrganizationsAuditLogExportResponseItemTokenRole.Read => "read",
                GetOrganizationsAuditLogExportResponseItemTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsAuditLogExportResponseItemTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => GetOrganizationsAuditLogExportResponseItemTokenRole.FineGrained,
                "read" => GetOrganizationsAuditLogExportResponseItemTokenRole.Read,
                "write" => GetOrganizationsAuditLogExportResponseItemTokenRole.Write,
                _ => null,
            };
        }
    }
}