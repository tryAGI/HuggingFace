
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsHardwareResponseItemAcceleratorManufacturer
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
    public static class GetJobsHardwareResponseItemAcceleratorManufacturerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsHardwareResponseItemAcceleratorManufacturer value)
        {
            return value switch
            {
                GetJobsHardwareResponseItemAcceleratorManufacturer.Aws => "AWS",
                GetJobsHardwareResponseItemAcceleratorManufacturer.Nvidia => "Nvidia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsHardwareResponseItemAcceleratorManufacturer? ToEnum(string value)
        {
            return value switch
            {
                "AWS" => GetJobsHardwareResponseItemAcceleratorManufacturer.Aws,
                "Nvidia" => GetJobsHardwareResponseItemAcceleratorManufacturer.Nvidia,
                _ => null,
            };
        }
    }
}