
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type
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
    public static class PatchOrganizationsResourceGroupsUsersResponseResourceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Bucket => "bucket",
                PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Dataset => "dataset",
                PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Kernel => "kernel",
                PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Model => "model",
                PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Bucket,
                "dataset" => PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Dataset,
                "kernel" => PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Kernel,
                "model" => PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Model,
                "space" => PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type.Space,
                _ => null,
            };
        }
    }
}