
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type
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
    public static class CreateOrganizationsResourceGroupsUsersResponseResourceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Bucket => "bucket",
                CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Dataset => "dataset",
                CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Kernel => "kernel",
                CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Model => "model",
                CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Bucket,
                "dataset" => CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Dataset,
                "kernel" => CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Kernel,
                "model" => CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Model,
                "space" => CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Space,
                _ => null,
            };
        }
    }
}