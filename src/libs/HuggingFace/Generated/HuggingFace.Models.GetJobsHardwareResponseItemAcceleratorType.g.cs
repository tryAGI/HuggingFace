
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsHardwareResponseItemAcceleratorType
    {
        /// <summary>
        /// 
        /// </summary>
        Gpu,
        /// <summary>
        /// 
        /// </summary>
        Neuron,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetJobsHardwareResponseItemAcceleratorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsHardwareResponseItemAcceleratorType value)
        {
            return value switch
            {
                GetJobsHardwareResponseItemAcceleratorType.Gpu => "gpu",
                GetJobsHardwareResponseItemAcceleratorType.Neuron => "neuron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsHardwareResponseItemAcceleratorType? ToEnum(string value)
        {
            return value switch
            {
                "gpu" => GetJobsHardwareResponseItemAcceleratorType.Gpu,
                "neuron" => GetJobsHardwareResponseItemAcceleratorType.Neuron,
                _ => null,
            };
        }
    }
}