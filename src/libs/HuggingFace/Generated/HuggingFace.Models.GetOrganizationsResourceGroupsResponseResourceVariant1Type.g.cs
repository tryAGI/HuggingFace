
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseResourceVariant1Type
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
    public static class GetOrganizationsResourceGroupsResponseResourceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseResourceVariant1Type value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseResourceVariant1Type.Bucket => "bucket",
                GetOrganizationsResourceGroupsResponseResourceVariant1Type.Dataset => "dataset",
                GetOrganizationsResourceGroupsResponseResourceVariant1Type.Kernel => "kernel",
                GetOrganizationsResourceGroupsResponseResourceVariant1Type.Model => "model",
                GetOrganizationsResourceGroupsResponseResourceVariant1Type.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseResourceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetOrganizationsResourceGroupsResponseResourceVariant1Type.Bucket,
                "dataset" => GetOrganizationsResourceGroupsResponseResourceVariant1Type.Dataset,
                "kernel" => GetOrganizationsResourceGroupsResponseResourceVariant1Type.Kernel,
                "model" => GetOrganizationsResourceGroupsResponseResourceVariant1Type.Model,
                "space" => GetOrganizationsResourceGroupsResponseResourceVariant1Type.Space,
                _ => null,
            };
        }
    }
}