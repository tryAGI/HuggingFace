
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsResourceGroupsResponseResourceVariant1Type
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
    public static class PatchOrganizationsResourceGroupsResponseResourceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsResponseResourceVariant1Type value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsResponseResourceVariant1Type.Bucket => "bucket",
                PatchOrganizationsResourceGroupsResponseResourceVariant1Type.Dataset => "dataset",
                PatchOrganizationsResourceGroupsResponseResourceVariant1Type.Kernel => "kernel",
                PatchOrganizationsResourceGroupsResponseResourceVariant1Type.Model => "model",
                PatchOrganizationsResourceGroupsResponseResourceVariant1Type.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsResponseResourceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchOrganizationsResourceGroupsResponseResourceVariant1Type.Bucket,
                "dataset" => PatchOrganizationsResourceGroupsResponseResourceVariant1Type.Dataset,
                "kernel" => PatchOrganizationsResourceGroupsResponseResourceVariant1Type.Kernel,
                "model" => PatchOrganizationsResourceGroupsResponseResourceVariant1Type.Model,
                "space" => PatchOrganizationsResourceGroupsResponseResourceVariant1Type.Space,
                _ => null,
            };
        }
    }
}