
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesHardwareResponseItemAcceleratorType
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
    public static class GetSpacesHardwareResponseItemAcceleratorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesHardwareResponseItemAcceleratorType value)
        {
            return value switch
            {
                GetSpacesHardwareResponseItemAcceleratorType.Gpu => "gpu",
                GetSpacesHardwareResponseItemAcceleratorType.Neuron => "neuron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesHardwareResponseItemAcceleratorType? ToEnum(string value)
        {
            return value switch
            {
                "gpu" => GetSpacesHardwareResponseItemAcceleratorType.Gpu,
                "neuron" => GetSpacesHardwareResponseItemAcceleratorType.Neuron,
                _ => null,
            };
        }
    }
}