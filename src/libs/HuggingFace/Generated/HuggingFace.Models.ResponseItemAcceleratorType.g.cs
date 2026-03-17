
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemAcceleratorType
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
    public static class ResponseItemAcceleratorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemAcceleratorType value)
        {
            return value switch
            {
                ResponseItemAcceleratorType.Gpu => "gpu",
                ResponseItemAcceleratorType.Neuron => "neuron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemAcceleratorType? ToEnum(string value)
        {
            return value switch
            {
                "gpu" => ResponseItemAcceleratorType.Gpu,
                "neuron" => ResponseItemAcceleratorType.Neuron,
                _ => null,
            };
        }
    }
}