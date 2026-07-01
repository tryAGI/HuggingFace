
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type
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
    public static class DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type value)
        {
            return value switch
            {
                DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Bucket => "bucket",
                DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Dataset => "dataset",
                DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Kernel => "kernel",
                DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Model => "model",
                DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Bucket,
                "dataset" => DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Dataset,
                "kernel" => DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Kernel,
                "model" => DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Model,
                "space" => DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Space,
                _ => null,
            };
        }
    }
}