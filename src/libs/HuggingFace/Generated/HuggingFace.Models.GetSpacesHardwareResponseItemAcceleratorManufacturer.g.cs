
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesHardwareResponseItemAcceleratorManufacturer
    {
        /// <summary>
        /// 
        /// </summary>
        Aws,
        /// <summary>
        /// 
        /// </summary>
        Nvidia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpacesHardwareResponseItemAcceleratorManufacturerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesHardwareResponseItemAcceleratorManufacturer value)
        {
            return value switch
            {
                GetSpacesHardwareResponseItemAcceleratorManufacturer.Aws => "AWS",
                GetSpacesHardwareResponseItemAcceleratorManufacturer.Nvidia => "Nvidia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesHardwareResponseItemAcceleratorManufacturer? ToEnum(string value)
        {
            return value switch
            {
                "AWS" => GetSpacesHardwareResponseItemAcceleratorManufacturer.Aws,
                "Nvidia" => GetSpacesHardwareResponseItemAcceleratorManufacturer.Nvidia,
                _ => null,
            };
        }
    }
}