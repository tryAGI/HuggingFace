
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsResponseResourceVariant1Type
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
    public static class CreateOrganizationsResourceGroupsResponseResourceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsResponseResourceVariant1Type value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsResponseResourceVariant1Type.Bucket => "bucket",
                CreateOrganizationsResourceGroupsResponseResourceVariant1Type.Dataset => "dataset",
                CreateOrganizationsResourceGroupsResponseResourceVariant1Type.Kernel => "kernel",
                CreateOrganizationsResourceGroupsResponseResourceVariant1Type.Model => "model",
                CreateOrganizationsResourceGroupsResponseResourceVariant1Type.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsResponseResourceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => CreateOrganizationsResourceGroupsResponseResourceVariant1Type.Bucket,
                "dataset" => CreateOrganizationsResourceGroupsResponseResourceVariant1Type.Dataset,
                "kernel" => CreateOrganizationsResourceGroupsResponseResourceVariant1Type.Kernel,
                "model" => CreateOrganizationsResourceGroupsResponseResourceVariant1Type.Model,
                "space" => CreateOrganizationsResourceGroupsResponseResourceVariant1Type.Space,
                _ => null,
            };
        }
    }
}