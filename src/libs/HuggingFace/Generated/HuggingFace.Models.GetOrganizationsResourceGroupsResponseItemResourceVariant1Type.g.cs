
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseItemResourceVariant1Type
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
    public static class GetOrganizationsResourceGroupsResponseItemResourceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseItemResourceVariant1Type value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseItemResourceVariant1Type.Bucket => "bucket",
                GetOrganizationsResourceGroupsResponseItemResourceVariant1Type.Dataset => "dataset",
                GetOrganizationsResourceGroupsResponseItemResourceVariant1Type.Kernel => "kernel",
                GetOrganizationsResourceGroupsResponseItemResourceVariant1Type.Model => "model",
                GetOrganizationsResourceGroupsResponseItemResourceVariant1Type.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseItemResourceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetOrganizationsResourceGroupsResponseItemResourceVariant1Type.Bucket,
                "dataset" => GetOrganizationsResourceGroupsResponseItemResourceVariant1Type.Dataset,
                "kernel" => GetOrganizationsResourceGroupsResponseItemResourceVariant1Type.Kernel,
                "model" => GetOrganizationsResourceGroupsResponseItemResourceVariant1Type.Model,
                "space" => GetOrganizationsResourceGroupsResponseItemResourceVariant1Type.Space,
                _ => null,
            };
        }
    }
}